using BetterCalculator.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace BetterCalculator
{
    internal static class Processer
    {
        internal static Tool Tool = new Tool();
        internal static List<string> GetInputList()
        {
            return Console.ReadLine().Split( ',' ).ToList();
        }
        internal static List<BigInteger> ParseListBI( List<string> list )
        {
            List<BigInteger> _ = new List<BigInteger> { };
            foreach (string str in list)
            {
                _.Add( BigInteger.Parse( str ) );
            }
            return _;
        }
        internal static BigInteger IExpo( BigInteger n, BigInteger e )
        {
            BigInteger _ = n;
            for (int i = 0; i < e - 1; i++)
            {
                _ *= n;
            }
            return _;
        }
        internal static BigInteger ISumList( List<BigInteger> bigIntegers )
        {
            BigInteger _ = BigInteger.Zero;
            foreach (BigInteger bi in bigIntegers)
            {
                _ += bi;
            }
            return _;
        }
        internal static BigInteger Fibo( BigInteger index )
        {
            BigInteger _1 = 1;
            BigInteger _2 = 1;
            BigInteger _3 = 1;
            for (BigInteger i = 0; i < index; i++)
            {
                if (i <= 1)
                    _3 = i;
                else
                {
                    _3 = _1 + _2;
                    _1 = _2;
                    _2 = _3;
                }
            }
            return _3;
        }
        internal static DivisionsIndex PF( BigInteger n )
        {
            BigInteger __ = n;
            DivisionsIndex _ = new DivisionsIndex();
            _.ReNew();
            if (n < 3)
            {
                _.AddNew( n );
                return _;
            }
            bool cont = true;
            bool dn = false;
            while (__ > 1)
            {
                cont = true;
                dn = false;
                for (BigInteger i = 2; cont && (i < (n / 2) + 1); i++)
                {
                    if (__ % i == 0)
                    {
                        _.AddNew( i );
                        __ /= i;
                        cont = false;
                        dn = true;
                    }
                }
                if (!dn)
                {
                    _.AddNew( __ );
                    break;
                }
            }
            _.Compress();
            return _;
        }
        internal static DivisionsIndex HighestCommonDivider( DivisionsIndex div1, DivisionsIndex div2 )
        {
            DivisionsIndex _ = new DivisionsIndex();
            _.ReNew();
            foreach (DivisionFactor df1 in div1.divisions)
            {
                foreach (DivisionFactor df2 in div2.divisions)
                {
                    if (df1.EqualTo( df2 ))
                    {
                        _.AddNew( Tool.Min( df1, df2 ) );
                        break;
                    }
                }
            }
            _.Compress();
            return _;
        }
        internal static DivisionsIndex LowestCommonMultiple( DivisionsIndex div1, DivisionsIndex div2 )
        {
            DivisionsIndex _ = new DivisionsIndex();
            _.ReNew();
            bool dono = false;
            foreach (DivisionFactor df1 in div1.divisions)
            {
                dono = true;
                foreach (DivisionFactor df2 in div2.divisions)
                {
                    if (df1.EqualTo( df2 ))
                    {
                        _.AddNew( Tool.Max( df1, df2 ) );
                        dono = false;
                        break;
                    }
                }
                if (dono)
                {
                    _.AddNew( df1 );
                }
            }
            _.Compress();
            return _;
        }
        internal static BigInteger MatrixMultipilication( List<BigInteger> bgs1, List<BigInteger> bgs2 )
        {
            BigInteger _ = 0;
            foreach (BigInteger bg1 in bgs1)
            {
                foreach (BigInteger bg2 in bgs2)
                {
                    _ += bg1 * bg2;
                }
            }
            return _;
        }
    }
}
