using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECalc
{
    static class Program
    {
        static BigInteger ms = 0;
        static void C()
        {
            Console.WriteLine("ECalc Made By [tyuXX]\n\n");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                BigInteger ans,n1,n2 = 0;
                C();
                Console.WriteLine("Options:\n[1]-Integer Addition\n[2]-Integer Subtraction\n[3]-Integer Multiplication\n[4]-Integer Division\n[5]Integer Moderation\n[6]-Integer Exponent");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        {
                            C();
                            Console.WriteLine("Number 1:\n");
                            BigInteger.TryParse(Console.ReadLine(),out n1);
                            Console.Clear();
                            C();
                            Console.WriteLine("Number 2:\n");
                            BigInteger.TryParse(Console.ReadLine(), out n2);
                            Console.Clear();
                            C();
                            ans = n1 + n2;
                            Console.WriteLine("Answer is:" + ans);
                            ans = 0;
                            n1 = 0;
                            n2 = 0;
                            break;
                        }
                    case '2':
                        {
                            C();
                            Console.WriteLine("Number 1:\n");
                            BigInteger.TryParse(Console.ReadLine(), out n1);
                            Console.Clear();
                            C();
                            Console.WriteLine("Number 2:\n");
                            BigInteger.TryParse(Console.ReadLine(), out n2);
                            Console.Clear();
                            C();
                            ans = n1 - n2;
                            Console.WriteLine("Answer is:" + ans);
                            ans = 0;
                            n1 = 0;
                            n2 = 0;
                            break;
                        }
                    case '3':
                        {
                            C();
                            Console.WriteLine("Number 1:\n");
                            BigInteger.TryParse(Console.ReadLine(), out n1);
                            Console.Clear();
                            C();
                            Console.WriteLine("Number 2:\n");
                            BigInteger.TryParse(Console.ReadLine(), out n2);
                            Console.Clear();
                            C();
                            ans = n1 * n2;
                            Console.WriteLine("Answer is:" + ans);
                            ans = 0;
                            n1 = 0;
                            n2 = 0;
                            break;
                        }
                    case '4':
                        {
                            C();
                            Console.WriteLine("Number 1:\n");
                            BigInteger.TryParse(Console.ReadLine(), out n1);
                            Console.Clear();
                            C();
                            Console.WriteLine("Number 2:\n");
                            BigInteger.TryParse(Console.ReadLine(), out n2);
                            Console.Clear();
                            C();
                            ans = n1 / n2;
                            Console.WriteLine("Answer is:" + ans);
                            ans = 0;
                            n1 = 0;
                            n2 = 0;
                            break;
                        }
                    case '5':
                        {
                            C();
                            Console.WriteLine("Number 1:\n");
                            BigInteger.TryParse(Console.ReadLine(), out n1);
                            Console.Clear();
                            C();
                            Console.WriteLine("Number 2:\n");
                            BigInteger.TryParse(Console.ReadLine(), out n2);
                            Console.Clear();
                            C();
                            ans = n1 % n2;
                            Console.WriteLine("Answer is:" + ans);
                            ans = 0;
                            n1 = 0;
                            n2 = 0;
                            break;
                        }
                    case '6':
                        {
                            C();
                            Console.WriteLine("Number 1:\n");
                            BigInteger.TryParse(Console.ReadLine(), out n1);
                            Console.Clear();
                            C();
                            Console.WriteLine("Number 2:\n");
                            BigInteger.TryParse(Console.ReadLine(), out n2);
                            Console.Clear();
                            C();
                            ans = n1;
                            for (BigInteger i = 0; i < n2; i++)
                            {
                                ans *= ans;
                            }
                            Console.WriteLine("Answer is:" + ans);
                            ans = 0;
                            n1 = 0;
                            n2 = 0;
                            break;
                        }
                }
            }
        }
    }
}
