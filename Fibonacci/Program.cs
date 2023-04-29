using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Fibonacci
{
    internal class Program
    {
        internal static List<BigInteger> nums = new List<BigInteger> { };
        internal static void Main( string[] args )
        {
            while (true)
            {
                Console.Write( "Index:" );
                int idx = int.Parse( Console.ReadLine());
                Console.WriteLine($"Number at index:{idx} is:{Fibonacci( idx )}");
            }
        }
        internal static BigInteger Fibonacci( int n )
        {
            if (n < 1)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            try { return nums.ElementAt( n ); }catch(Exception) { }
            BigInteger rt = Fibonacci( n - 1 ) + Fibonacci( n - 2 );
            nums.Add( rt );
            return rt;
        }
    }
}
