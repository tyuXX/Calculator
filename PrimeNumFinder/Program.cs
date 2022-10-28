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
        static Random r = new Random();
        static int d = r.Next(0, int.MaxValue);
        static BigInteger t = 0;
        static string n = "PNF #" + d;
        static void Main(string[] args)
        {
            List<BigInteger> bigIntegers = new List<BigInteger> {2};
            BigInteger i = 0;
            Thread.CurrentThread.Name = n;
            Console.Title = Thread.CurrentThread.Name;
            bool pr = false;
            bool wr = false;
            BigInteger st = -1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("PNF Made by [tyuXX]");
                Console.WriteLine("\n\nOptions:\n[1]-Print to the console\nState:" + pr + "\n\n[2]-Write to File\nState:" + wr + "\n\n[3]-Set Limit\nState:" + st);
                ConsoleKey a = Console.ReadKey().Key;
                if(a == ConsoleKey.D1)
                {
                    if (pr)
                    {
                        pr = false;
                    }
                    else
                    {
                        pr = true;
                    }
                }
                else if (a == ConsoleKey.D2)
                {
                    if (wr)
                    {
                        wr = false;
                    }
                    else
                    {
                        wr = true;
                    }
                }
                else if (a == ConsoleKey.D3)
                {
                    Console.Clear();
                    Console.WriteLine("Please input a valid number.\n\n");
                    try { st = BigInteger.Parse(Console.ReadLine()); } catch (Exception) { }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("PNF Made by [tyuXX]\n\n");
                    break;
                }
            }
            if (wr && !Directory.Exists(@".\primes\"))
            {
                Directory.CreateDirectory(@".\primes\");
            }
            Thread tth = new Thread(TimerTH);
            tth.Start();
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
                    if (pr) { Console.WriteLine(i + " T:" + t); }
                    if (wr) { File.AppendAllText(@".\primes\" + n + ".pnst", "[" + i + " T:" + t + "] , "); }
                    bigIntegers.Add(i);
                }
                if(i == st) { break; }
                i++;
            }
        }
        static void TimerTH()
        {
            Thread.CurrentThread.Name = n + "PNFT #" + d;
            while (true)
            {
                Thread.Sleep(1000);
                t++;
            }
        }
    }
}