using System;
using System.Numerics;

namespace SpeedTest
{
    class Program
    {
        static void Main()
        {
            BigInteger ii = 0;
            for (BigInteger i = 0; i < 1000000; i++)
            {
                ii++;
            }
            Console.WriteLine(ii);
            Console.ReadKey();
        }
    }
}
