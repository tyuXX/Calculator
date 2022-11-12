using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace x2
{
    class Program
    {
        static BigInteger time = 0;
        static Random r = new Random();
        static bool cheat = false;
        static void C()
        {
            Console.WriteLine("x2 Made By [tyuXX]\n\n");
        }
        static void Timer()
        {
            while (true)
            {
                Thread.Sleep(999);
                time++;
            }
        }
        static void Main(string[] args)
        {
            Thread th = new Thread(Timer);
            th.Start();
            while (true)
            {
                Console.Clear();
                C();
                Console.WriteLine("Options:\n[0]-x?\n[1]-x2\n[2]-x3\n[3]-x4\n[4]-x5\n[5]-x6\n[6]-x7\n[7]-x8\n[8]-x9");
                switch (Console.ReadKey().KeyChar)
                {
                    case 'd':
                        {
                            Console.Clear();
                            C();
                            Console.WriteLine("Input key.");
                            if (Console.ReadKey().KeyChar == 'c')
                            {
                                Console.Clear();
                                C();
                                Console.Write("Input PassCode:");
                                string crl = Console.ReadLine();
                                if ((crl == "$sudo cheats toggle")||(crl == "$sct"))
                                {
                                    if (cheat)
                                    {
                                        cheat = false;
                                    }
                                    else
                                    {
                                        cheat = true;
                                    }
                                }
                            }
                            break;
                        }
                    case '0':
                        {
                            time = 0;
                            BigInteger s = 0;
                            BigInteger num = r.Next(-256, 256);
                            while (true)
                            {
                                Console.Clear();
                                C();
                                BigInteger t = r.Next(-1000, 1000);
                                Console.WriteLine("Time: " + time + "\n");
                                Console.Write("Calculate " + t + " * ");
                                Console.Write(num + "\nAnswer:");
                                BigInteger ans = 0;
                                BigInteger.TryParse(Console.ReadLine(), out ans);
                                if ((ans == num * t)||(cheat && !(ans == 1234567890)))
                                {
                                    s++;
                                    num *= t;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("You lost Score:" + s + " Time:" + time + "\n");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;
                        }
                    case '1':
                        {
                            time = 0;
                            BigInteger s = 0;
                            BigInteger num = r.Next(-256, 256);
                            while (true)
                            {
                                Console.Clear();
                                C();
                                BigInteger t = 2;
                                Console.WriteLine("Time: " + time + "\n");
                                Console.Write("Calculate " + t + " * ");
                                Console.Write(num + "\nAnswer:");
                                BigInteger ans = 0;
                                BigInteger.TryParse(Console.ReadLine(), out ans);
                                if ((ans == num * t)||(cheat && !(ans == 1234567890)))
                                {
                                    s++;
                                    num *= t;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("You lost Score:" + s + " Time:" + time + "\n");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;
                        }
                    case '2':
                        {
                            time = 0;
                            BigInteger s = 0;
                            BigInteger num = r.Next(-256, 256);
                            while (true)
                            {
                                Console.Clear();
                                C();
                                BigInteger t = 3;
                                Console.WriteLine("Time: " + time + "\n");
                                Console.Write("Calculate " + t + " * ");
                                Console.Write(num + "\nAnswer:");
                                BigInteger ans = 0;
                                BigInteger.TryParse(Console.ReadLine(), out ans);
                                if ((ans == num * t)||(cheat && !(ans == 1234567890)))
                                {
                                    s++;
                                    num *= t;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("You lost Score:" + s + " Time:" + time + "\n");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;
                        }
                    case '3':
                        {
                            time = 0;
                            BigInteger s = 0;
                            BigInteger num = r.Next(-256, 256);
                            while (true)
                            {
                                Console.Clear();
                                C();
                                BigInteger t = 4;
                                Console.WriteLine("Time: " + time + "\n");
                                Console.Write("Calculate " + t + " * ");
                                Console.Write(num + "\nAnswer:");
                                BigInteger ans = 0;
                                BigInteger.TryParse(Console.ReadLine(), out ans);
                                if ((ans == num * t)||(cheat && !(ans == 1234567890)))
                                {
                                    s++;
                                    num *= t;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("You lost Score:" + s + " Time:" + time + "\n");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;
                        }
                    case '4':
                        {
                            time = 0;
                            BigInteger s = 0;
                            BigInteger num = r.Next(-256, 256);
                            while (true)
                            {
                                Console.Clear();
                                C();
                                BigInteger t = 5;
                                Console.WriteLine("Time: " + time + "\n");
                                Console.Write("Calculate " + t + " * ");
                                Console.Write(num + "\nAnswer:");
                                BigInteger ans = 0;
                                BigInteger.TryParse(Console.ReadLine(), out ans);
                                if ((ans == num * t)||(cheat && !(ans == 1234567890)))
                                {
                                    s++;
                                    num *= t;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("You lost Score:" + s + " Time:" + time + "\n");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;
                        }
                    case '5':
                        {
                            time = 0;
                            BigInteger s = 0;
                            BigInteger num = r.Next(-256, 256);
                            while (true)
                            {
                                Console.Clear();
                                C();
                                BigInteger t = 6;
                                Console.WriteLine("Time: " + time + "\n");
                                Console.Write("Calculate " + t + " * ");
                                Console.Write(num + "\nAnswer:");
                                BigInteger ans = 0;
                                BigInteger.TryParse(Console.ReadLine(), out ans);
                                if ((ans == num * t)||(cheat && !(ans == 1234567890)))
                                {
                                    s++;
                                    num *= t;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("You lost Score:" + s + " Time:" + time + "\n");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;
                        }
                    case '6':
                        {
                            time = 0;
                            BigInteger s = 0;
                            BigInteger num = r.Next(-256, 256);
                            while (true)
                            {
                                Console.Clear();
                                C();
                                BigInteger t = 7;
                                Console.WriteLine("Time: " + time + "\n");
                                Console.Write("Calculate " + t + " * ");
                                Console.Write(num + "\nAnswer:");
                                BigInteger ans = 0;
                                BigInteger.TryParse(Console.ReadLine(), out ans);
                                if ((ans == num * t)||(cheat && !(ans == 1234567890)))
                                {
                                    s++;
                                    num *= t;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("You lost Score:" + s + " Time:" + time + "\n");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;
                        }
                    case '7':
                        {
                            time = 0;
                            BigInteger s = 0;
                            BigInteger num = r.Next(-256, 256);
                            while (true)
                            {
                                Console.Clear();
                                C();
                                BigInteger t = 8;
                                Console.WriteLine("Time: " + time + "\n");
                                Console.Write("Calculate " + t + " * ");
                                Console.Write(num + "\nAnswer:");
                                BigInteger ans = 0;
                                BigInteger.TryParse(Console.ReadLine(), out ans);
                                if ((ans == num * t)||(cheat && !(ans == 1234567890)))
                                {
                                    s++;
                                    num *= t;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("You lost Score:" + s + " Time:" + time + "\n");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;
                        }
                    case '8':
                        {
                            time = 0;
                            BigInteger s = 0;
                            BigInteger num = r.Next(-256, 256);
                            while (true)
                            {
                                Console.Clear();
                                C();
                                BigInteger t = 9;
                                Console.WriteLine("Time: " + time + "\n");
                                Console.Write("Calculate " + t + " * ");
                                Console.Write(num + "\nAnswer:");
                                BigInteger ans = 0;
                                BigInteger.TryParse(Console.ReadLine(), out ans);
                                if ((ans == num * t)||(cheat && !(ans == 1234567890)))
                                {
                                    s++;
                                    num *= t;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("You lost Score:" + s + " Time:" + time + "\n");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;
                        }
                }
            }
        }
    }
}
