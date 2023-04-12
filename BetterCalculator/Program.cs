using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BetterCalculator.Processer;

namespace BetterCalculator
{
    internal static class Program
    {
        internal const decimal version = 1.0M;
        internal static Random rng = new Random();
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
                    Integers();
                    break;
                case ConsoleKey.D2:
                    Rationals();
                    break;
                default:
                    break;
            }
        }
        internal static void Rationals()
        {
            Splash();
        }
        internal static void Integers()
        {
            Splash();
            Console.WriteLine("[1]-Addition");
            Console.WriteLine("[2]-Subtraction");
            Console.WriteLine("[3]-Multipilication");
            Console.WriteLine("[4]-Division");
            Console.WriteLine("[5]-Exponent");
            Console.WriteLine("[6]-Sum List");
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
                    break;
                default:
                    break;
            }
        }
        internal static void Main()
        {
            Splash();
            MainMenu();
        }
    }
}
