using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static BetterCalculator.Program;

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
                _ -= bi;
            }
            return _;
        }
        internal static void IAddition()
        {
            Splash();
            Console.Write("First Number:");
            BigInteger.TryParse(Console.ReadLine(),out BigInteger n1);
            Console.Write("Second Number:");
            BigInteger.TryParse(Console.ReadLine(),out BigInteger n2);
            Console.WriteLine("Answer:" + (n1+n2));
            Main();
        }
        internal static void ISubtraction()
        {
            Splash();
            Console.Write("First Number:");
            BigInteger.TryParse(Console.ReadLine(),out BigInteger n1);
            Console.Write("Second Number:");
            BigInteger.TryParse(Console.ReadLine(),out BigInteger n2);
            Console.WriteLine("Answer:" + (n1-n2));
            Main();
        }
        internal static void IMultipilication()
        {
            Splash();
            Console.Write("First Number:");
            BigInteger.TryParse(Console.ReadLine(),out BigInteger n1);
            Console.Write("Second Number:");
            BigInteger.TryParse(Console.ReadLine(),out BigInteger n2);
            Console.WriteLine("Answer:" + (n1*n2));
            Main();
        }
        internal static void IDivision()
        {
            Splash();
            Console.Write("First Number:");
            BigInteger.TryParse(Console.ReadLine(),out BigInteger n1);
            Console.Write("Second Number:");
            BigInteger.TryParse(Console.ReadLine(),out BigInteger n2);
            Console.WriteLine("Answer:" + (n1/n2));
            Main();
        }
        internal static void IExponent()
        {
            Splash();
            Console.Write("First Number:");
            BigInteger.TryParse(Console.ReadLine(),out BigInteger n1);
            Console.Write("Second Number:");
            BigInteger.TryParse(Console.ReadLine(),out BigInteger n2);
            Console.WriteLine("Answer:" + IExpo(n1,n2)); ;
            Main();
        }
        internal static void ISum()
        {
            Splash();
            Console.WriteLine("List:");
            Console.WriteLine("Answer:" + ISumList(ParseListBI(GetInputList())));
            Main();
        }
    }
}
