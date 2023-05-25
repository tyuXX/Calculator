using BetterCalculator.Structs;
using System;
using System.Collections.Generic;
using System.Numerics;
using static BetterCalculator.Processer;
using static BetterCalculator.Program;

namespace BetterCalculator
{
    internal static class UserProcs
    {
        internal static List<BigInteger> memory = new List<BigInteger>() { 0 };
        internal static BigInteger GetFromMemory()
        {
            return 0;
        }
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
        internal static void DAddition()
        {
            Splash();
            Console.Write( "First Number:" );
            Decimal.TryParse( Console.ReadLine(), out Decimal n1 );
            Console.Write( "Second Number:" );
            Decimal.TryParse( Console.ReadLine(), out Decimal n2 );
            Console.WriteLine( "Answer:" + (n1 + n2) );
            Main();
        }
        internal static void IPrimeFactorization()
        {
            Splash();
            Console.Write( "Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n );
            Console.Write( "Answer:" );
            bool isfirst = true;
            foreach (DivisionFactor df in PF( n ).divisions)
            {
                if (isfirst)
                {
                    isfirst = false;
                }
                else
                {
                    Console.Write( '*' );
                }
                Console.Write( $"{df.number}^{df.factor}" );
            }
            Main();
        }
        internal static void IHighestCommonDivider()
        {
            Splash();
            Console.Write( "First Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n1 );
            Console.Write( "Second Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n2 );
            Console.WriteLine( "Answer:" + HighestCommonDivider( PF( n1 ), PF( n2 ) ).GetNumber() );
            Main();
        }
        internal static void ILowestCommonMultiple()
        {
            Splash();
            Console.Write( "First Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n1 );
            Console.Write( "Second Number:" );
            BigInteger.TryParse( Console.ReadLine(), out BigInteger n2 );
            Console.WriteLine( "Answer:" + LowestCommonMultiple( PF( n1 ), PF( n2 ) ).GetNumber() );
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
        internal static void IMatrixMultipilication()
        {
            Splash();
            Console.Write( "First Set:" );
            List<BigInteger> bgs1 = ParseListBI( GetInputList() );
            Console.Write( "Second Set:" );
            List<BigInteger> bgs2 = ParseListBI( GetInputList() );
            Console.WriteLine( "Answer:" + MatrixMultipilication( bgs1, bgs2 ) );
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
