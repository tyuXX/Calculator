using System;
using System.Numerics;
using BetterCalculator.Structs;
using static BetterCalculator.Program;
using static BetterCalculator.Processer;

namespace BetterCalculator
{
    internal static class UserProcs
    {
        internal static void IAddition()
        {
            Splash();
            Console.Write( "First Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n1 );
            Console.Write( "Second Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n2 );
            Console.WriteLine( "Answer:" + (n1 + n2) );
            Main();
        }
        internal static void IPrimeFactorization()
        {
            Splash();
            Console.Write("Number:");
            BigInteger.TryParse(Console.ReadLine(), out BigInteger n);
            bool isfirst = true;
            foreach (DivisionFactor df in PF(n).divisions)
            {
                if (isfirst)
                {
                    isfirst = false;
                }
                else
                {
                    Console.Write(',');
                }
                Console.Write($"{df.number}^{df.factor}");
            }
            Main();
        }
        internal static void ISubtraction()
        {
            Splash();
            Console.Write( "First Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n1 );
            Console.Write( "Second Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n2 );
            Console.WriteLine( "Answer:" + (n1 - n2) );
            Main();
        }
        internal static void IMultipilication()
        {
            Splash();
            Console.Write( "First Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n1 );
            Console.Write( "Second Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n2 );
            Console.WriteLine( "Answer:" + (n1 * n2) );
            Main();
        }
        internal static void IDivision()
        {
            Splash();
            Console.Write( "First Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n1 );
            Console.Write( "Second Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n2 );
            Console.WriteLine( "Answer:" + (n1 / n2) );
            Main();
        }
        internal static void IExponent()
        {
            Splash();
            Console.Write( "First Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n1 );
            Console.Write( "Second Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n2 );
            Console.WriteLine( "Answer:" + IExpo( n1, n2 ) ); ;
            Main();
        }
        internal static void ISum()
        {
            Splash();
            Console.Write( "List:" );
            Console.WriteLine( "Answer:" + ISumList( ParseListBI( GetInputList() ) ) );
            Main();
        }
        internal static void IFibonacci()
        {
            Splash();
            Console.Write( "Index:" );
            Console.WriteLine( "Answer:" + Fibo( BigInteger.Parse( Console.ReadLine() ) ) );
            Main();
        }
    }
}
