using System.Collections.Generic;
using System.Numerics;

namespace BetterCalculator.Structs
{
    public struct Tool
    {
        public DivisionFactor Max( DivisionFactor df1, DivisionFactor df2 )
        {
            if (df1.factor == df2.factor)
            {
                return df1;
            }
            if (df1.factor > df2.factor)
            {
                return df1;
            }
            return df2;
        }
        public DivisionFactor Min( DivisionFactor df1, DivisionFactor df2 )
        {
            if (df1.factor == df2.factor)
            {
                return df1;
            }
            if (df1.factor < df2.factor)
            {
                return df1;
            }
            return df2;
        }
    }
    public struct DivisionFactor
    {
        public BigInteger number;
        public BigInteger factor;
        public bool inactive;
        public DivisionFactor( BigInteger pnumber, BigInteger pfactor )
        {
            number = pnumber;
            factor = pfactor;
            inactive = false;
        }
        public bool EqualTo( DivisionFactor df )
        {
            if (number == df.number)
            {
                return true;
            }
            return false;
        }
        public void Merge( DivisionFactor df )
        {
            if (EqualTo( df ))
            {
                factor += df.factor;
                df.Deactivate();
            }
        }
        public void Deactivate()
        {
            number = 1;
            factor = 1;
            inactive = true;
        }
        public BigInteger GetNumber()
        {
            BigInteger _ = 1;
            for (BigInteger i = 0; i < factor; i++)
            {
                _ *= number;
            }
            return _;
        }
    }
    public struct DivisionsIndex
    {
        public List<DivisionFactor> divisions;
        public DivisionsIndex( List<DivisionFactor> pivisions )
        {
            divisions = pivisions;
        }
        public void ReNew()
        {
            divisions = new List<DivisionFactor>() { };
        }
        public void Compress()
        {
            DivisionsIndex _ = new DivisionsIndex();
            DivisionsIndex __ = new DivisionsIndex();
            _.ReNew();
            __.ReNew();
            bool ___ = false;
            foreach (DivisionFactor df1 in divisions)
            {
                ___ = false;
                foreach (DivisionFactor df2 in __.divisions)
                {
                    if (df1.EqualTo( df2 ))
                    {
                        ___ = true;
                        break;
                    }
                }
                if (!___)
                {
                    __.AddNew( df1 );
                    _.AddNew( GetAllFactor( df1 ) );
                }
            }
            divisions = _.divisions;
        }
        public void AddNew( BigInteger n )
        {
            divisions.Add( new DivisionFactor( n, 1 ) );
        }
        public void AddNew( BigInteger n, BigInteger f )
        {
            divisions.Add( new DivisionFactor( n, f ) );
        }
        public void AddNew( DivisionFactor df )
        {
            divisions.Add( df );
        }
        public BigInteger GetNumber()
        {
            BigInteger _ = 1;
            foreach (DivisionFactor df in divisions)
            {
                _ *= df.GetNumber();
            }
            return _;
        }
        public DivisionFactor GetAllFactor( DivisionFactor pdf )
        {
            BigInteger _ = 0;
            foreach (DivisionFactor df in divisions)
            {
                if (df.EqualTo( pdf ))
                {
                    _ += df.factor;
                }
            }
            return new DivisionFactor( pdf.number, _ );
        }
    }
}
