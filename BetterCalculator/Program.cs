using System;
using static BetterCalculator.UserProcs;

namespace BetterCalculator
{
    internal static class Program
    {
        internal const decimal version = 1.0M;
        internal static Random rng = new Random();
        internal static bool fi = true;
        internal static void Splash()
        {
            Console.Clear();
            Console.WriteLine($"Better Calculator V{version.ToString().Replace(',','.')} Made By [tyuXX]\n");
        }
        internal static void MainMenu()
        {
            Console.WriteLine("[1]-Integers");
            Console.WriteLine("[2]-Rationals");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    IntegersP1();
                    break;
                case ConsoleKey.D2:
                    Rationals();
                    break;
                default:
                    Main();
                    break;
            }
        }
        internal static void Rationals()
        {
            Splash();
        }
        internal static void IntegersP1()
        {
            Splash();
            Console.WriteLine("[1]-Addition");
            Console.WriteLine("[2]-Subtraction");
            Console.WriteLine("[3]-Multipilication");
            Console.WriteLine("[4]-Division");
            Console.WriteLine("[5]-Exponent");
            Console.WriteLine("[6]-Sum List");
            Console.WriteLine("[7]-Fibonacci Index");
            Console.WriteLine("[8]-Highest Common Factor");
            Console.WriteLine("[9]-Lowest Common Multiple");
            Console.WriteLine("[0]-Page 2");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    IAddition();
                    break;
                case ConsoleKey.D2:
                    ISubtraction();
                    break;
                case ConsoleKey.D3:
                    IMultipilication();
                    break;
                case ConsoleKey.D4:
                    IDivision();
                    break;
                case ConsoleKey.D5:
                    IExponent();
                    break;
                case ConsoleKey.D6:
                    ISum();
                    break;
                case ConsoleKey.D7:
                    IFibonacci();
                    break;
                case ConsoleKey.D8:
                    //IFibonacci();
                    break;
                case ConsoleKey.D9:
                    //IFibonacci();
                    break;
                case ConsoleKey.D0:
                    IntegersP2();
                    break;
                default:
                    Main();
                    break;
            }
        }
        internal static void IntegersP2()
        {
            Splash();
            Console.WriteLine("[1]-Prime Factorization");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    IPrimeFactorization();
                    break;
                default:
                    Main();
                    break;
            }
        }
        internal static void Main()
        {
            if (!fi)
            {
                Console.ReadKey();
            }
            else
            {
                fi = false;
            }
            Splash();
            MainMenu();
        }
    }
}
