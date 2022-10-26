using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace PrimeNumFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> bigIntegers = new List<BigInteger> {2};
            BigInteger i = 2;
            BigInteger st = -1;
            bool pr = true;
            bool wr = true;
            while (true)
            {
                BigInteger c = 0;
                foreach(BigInteger s in bigIntegers)
                {
                    if(s>i)
                    {
                        break;
                    }
                    else if (i % s == 0)
                    {
                        break;
                    }
                    else
                    {
                        c++;
                    }
                }
                if(c >= bigIntegers.Count - 1)
                {
                    if (pr) { Console.WriteLine(i); }
                    if (wr) { File.AppendAllText(@".\primes", i + ","); }
                    bigIntegers.Add(i);
                }
                if(i == st) { break; }
                i++;
            }
        }
    }
}