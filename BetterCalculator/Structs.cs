using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace BetterCalculator.Structs
{
    public struct DivisionFactor
    {
        public BigInteger number;
        public BigInteger factor;
        public bool inactive;
        public DivisionFactor(BigInteger pnumber,BigInteger pfactor)
        {
            number = pnumber;
            factor = pfactor;
            inactive = false;
        }
        public bool EqualTo(DivisionFactor df)
        {
            if(number == df.number)
            {
                return true;
            }
            return false;
        }
        public void Merge(DivisionFactor df)
        {
            if (EqualTo(df))
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
    }
    public struct DivisionsIndex
    {
        public List<DivisionFactor> divisions;
        public DivisionsIndex(List<DivisionFactor> pivisions)
        {
            divisions = pivisions;
        }
        public void ReNew()
        {
            divisions = new List<DivisionFactor>() { };
        }
        public void Compress()
        {
            for (int i = 0; i < divisions.Count; i++)
            {
                for (int ii=0;ii<divisions.Count;ii++)
                {
                    divisions.ElementAt(i).Merge(divisions.ElementAt(ii));
                }
            }
            for (int i = 0; i < divisions.Count; i++)
            {
                if (divisions.ElementAt(i).inactive)
                {
                    divisions.RemoveAt(i);
                    i--;
                }
            }
        }
        public void AddNew(BigInteger n)
        {
            divisions.Add(new DivisionFactor(n,1));
        }
    }
}
