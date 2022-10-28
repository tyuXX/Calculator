using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace PrimeNumFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> bigIntegers = new List<BigInteger> {2};
            Random r = new Random();
            int d = r.Next(int.MinValue, int.MaxValue);
            BigInteger i = 2;
            BigInteger st = -1;
            bool pr = true;
            bool wr = true;
            if (wr)
            {
                Directory.CreateDirectory(@".\primes\");
            }
            while (true)
            {
                bool c = true;
                foreach(BigInteger s in bigIntegers)
                {
                    if ((i+1)>(s/2))
                    {
                        break;
                    }
                    else if(s>i)
                    {
                        c = false;
                        break;
                    }
                    else if (i % s == 0)
                    {
                        c = false;
                        break;
                    }
                }
                if(c)
                {
                    if (pr) { Console.WriteLine(i); }
                    if (wr) { File.AppendAllText(@".\primes\" + d, i + ","); }
                    bigIntegers.Add(i);
                }
                if(i == st) { break; }
                i++;
            }
        }
    }
}