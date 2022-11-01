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
                            Console.Clear();
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
                            Console.WriteLine("Answer is:" + ans + "\nPress Any Key To Continue");
                            ans = 0;
                            n1 = 0;
                            n2 = 0;
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case '2':
                        {
                            Console.Clear();
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
                            Console.WriteLine("Answer is:" + ans + "\nPress Any Key To Continue");
                            ans = 0;
                            n1 = 0;
                            n2 = 0;
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case '3':
                        {
                            Console.Clear();
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
                            Console.WriteLine("Answer is:" + ans + "\nPress Any Key To Continue");
                            ans = 0;
                            n1 = 0;
                            n2 = 0;
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case '4':
                        {
                            Console.Clear();
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
                            Console.WriteLine("Answer is:" + ans + "\nPress Any Key To Continue");
                            ans = 0;
                            n1 = 0;
                            n2 = 0;
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case '5':
                        {
                            Console.Clear();
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
                            Console.WriteLine("Answer is:" + ans + "\nPress Any Key To Continue");
                            ans = 0;
                            n1 = 0;
                            n2 = 0;
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case '6':
                        {
                            Console.Clear();
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
                            for (BigInteger i = 0; i < n2 - 1; i++)
                            {
                                ans *= n1;
                            }
                            Console.WriteLine("Answer is:" + ans + "\nPress Any Key To Continue");
                            ans = 0;
                            n1 = 0;
                            n2 = 0;
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            }
        }
    }
}
