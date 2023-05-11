using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using BetterCalculator.Structs;

namespace BetterCalculator
{
    internal static class Processer
    {
        internal static List<string> GetInputList()
        {
            return Console.ReadLine().Split(',').ToList();
        }
        internal static List<BigInteger> ParseListBI(List<string> list)
        {
            List<BigInteger> _ = new List<BigInteger> { };
            foreach (string str in list)
            {
                _.Add(BigInteger.Parse(str));
            }
            return _;
        }
        internal static BigInteger IExpo(BigInteger n , BigInteger e)
        {
            BigInteger _ = n;
            for (int i = 0; i < e-1; i++)
            {
                _ *= n;
            }
            return _;
        }
        internal static BigInteger ISumList(List<BigInteger> bigIntegers)
        {
            BigInteger _ = BigInteger.Zero;
            foreach (BigInteger bi in bigIntegers)
            {
                _ += bi;
            }
            return _;
        }
        internal static BigInteger Fibo(BigInteger index)
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
        internal static DivisionsIndex PF(BigInteger n)
        {
            BigInteger __ = n;
            DivisionsIndex _ = new DivisionsIndex();
            _.ReNew();
            bool cont = true;
            while(__ > 1)
            {
                cont = true;
                for (BigInteger i = 2; cont && (i < (n/2)+1);i++)
                {
                    if(__ % i == 0)
                    {
                        _.AddNew(i);
                        __ /= i;
                        cont = false;
                    }
                }
            }
            _.Compress();
            return _;
        }
    }
}
