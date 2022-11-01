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
                BigInteger ans = 0, n1 = 0, n2 = 0;
                Decimal ads = 0M, d1 = 0M, d2 = 0M;
                Console.Clear();
                C();
                Console.WriteLine("Options:\n[1]-Integer's\n[2]-Decimal's\n[3]-Complex's");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        {
                            Console.Clear();
                            C();
                            Console.WriteLine("Options:\n[1]-Integer Addition\n[2]-Integer Subtraction\n[3]-Integer Multiplication\n[4]-Integer Division\n[5]-Integer Moderation\n[6]-Integer Exponent");
                            switch (Console.ReadKey().KeyChar)
                            {
                                case '1':
                                    {
                                        try
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
                                            ans = n1 + n2;
                                            Console.WriteLine("Answer is:" + ans + "\nPress Any Key To Continue");
                                            ans = 0;
                                            n1 = 0;
                                            n2 = 0;
                                            Console.ReadKey();
                                        }
                                        catch (Exception) { }
                                        break;
                                    }
                                case '2':
                                    {
                                        try
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
                                        }
                                        catch (Exception) { }
                                        break;
                                    }
                                case '3':
                                    {
                                        try
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
                                        }
                                        catch (Exception) { }
                                        break;
                                    }
                                case '4':
                                    {
                                        try
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
                                        }
                                        catch (Exception) { }
                                        break;
                                    }
                                case '5':
                                    {
                                        try
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
                                        }
                                        catch (Exception) { }
                                        break;
                                    }
                                case '6':
                                    {
                                        try
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
                                        }
                                        catch (Exception) { }
                                        break;
                                    }
                            }
                            break;
                        }
                    case '2':
                        {
                            Console.Clear();
                            C();
                            Console.WriteLine("Options:\n[1]-Decimal Addition\n[2]-Decimal Subtraction\n[3]-Decimal Multiplication\n[4]-Decimal Division\n[5]-Decimal Moderation\n[6]-Decimal Exponent");
                            switch (Console.ReadKey().KeyChar)
                            {
                                case '1':
                                    {
                                        try
                                        {
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 1:\n");
                                            Decimal.TryParse(Console.ReadLine().Replace('.', ','), out d1);
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 2:\n");
                                            Decimal.TryParse(Console.ReadLine().Replace('.', ','), out d2);
                                            Console.Clear();
                                            C();
                                            ads = d1 + d2;
                                            Console.WriteLine(("Answer is:" + ads + "\nPress Any Key To Continue").Replace(',', '.'));
                                            ads = 0;
                                            d1 = 0;
                                            d2 = 0;
                                            Console.ReadKey();
                                        }
                                        catch (Exception) { }
                                        break;
                                    }
                                case '2':
                                    {
                                        try
                                        {
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 1:\n");
                                            Decimal.TryParse(Console.ReadLine().Replace('.', ','), out d1);
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 2:\n");
                                            Decimal.TryParse(Console.ReadLine().Replace('.', ','), out d2);
                                            Console.Clear();
                                            C();
                                            ads = d1 - d2;
                                            Console.WriteLine(("Answer is:" + ads + "\nPress Any Key To Continue").Replace(',', '.'));
                                            ads = 0;
                                            d1 = 0;
                                            d2 = 0;
                                            Console.ReadKey();
                                        }
                                        catch (Exception) { }
                                        break;
                                    }
                                case '3':
                                    {
                                        try
                                        {
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 1:\n");
                                            Decimal.TryParse(Console.ReadLine().Replace('.', ','), out d1);
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 2:\n");
                                            Decimal.TryParse(Console.ReadLine().Replace('.', ','), out d2);
                                            Console.Clear();
                                            C();
                                            ads = d1 * d2;
                                            Console.WriteLine(("Answer is:" + ads + "\nPress Any Key To Continue").Replace(',', '.'));
                                            ads = 0;
                                            d1 = 0;
                                            d2 = 0;
                                            Console.ReadKey();
                                        }
                                        catch(Exception) { }
                                        break;
                                    }
                                case '4':
                                    {
                                        try
                                        {
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 1:\n");
                                            Decimal.TryParse(Console.ReadLine().Replace('.', ','), out d1);
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 2:\n");
                                            Decimal.TryParse(Console.ReadLine().Replace('.', ','), out d2);
                                            Console.Clear();
                                            C();
                                            ans = n1 / n2;
                                            Console.WriteLine(("Answer is:" + ads + "\nPress Any Key To Continue").Replace(',', '.'));
                                            ans = 0;
                                            n1 = 0;
                                            n2 = 0;
                                            Console.ReadKey();
                                        }
                                        catch (Exception) { }
                                        break;
                                    }
                                case '5':
                                    {
                                        try
                                        {
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 1:\n");
                                            Decimal.TryParse(Console.ReadLine().Replace('.', ','), out d1);
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 2:\n");
                                            Decimal.TryParse(Console.ReadLine().Replace('.', ','), out d2);
                                            Console.Clear();
                                            C();
                                            ans = n1 % n2;
                                            Console.WriteLine(("Answer is:" + ads + "\nPress Any Key To Continue").Replace(',', '.'));
                                            ans = 0;
                                            n1 = 0;
                                            n2 = 0;
                                            Console.ReadKey();
                                        }
                                        catch (Exception) { }
                                        break;
                                    }
                                case '6':
                                    {
                                        try
                                        {
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 1:\n");
                                            Decimal.TryParse(Console.ReadLine().Replace('.', ','), out d1);
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 2:\n");
                                            Decimal.TryParse(Console.ReadLine().Replace('.', ','), out d2);
                                            Console.Clear();
                                            C();
                                            ads = d1;
                                            for (Decimal i = 0; i < d2 - 1; i++)
                                            {
                                                ads *= d1;
                                            }
                                            Console.WriteLine(("Answer is:" + ads + "\nPress Any Key To Continue").Replace(',', '.'));
                                            ads = 0;
                                            d1 = 0;
                                            d2 = 0;
                                            Console.ReadKey();
                                        }
                                        catch (Exception) { }
                                        break;
                                    }
                            }
                            break;
                        }
                    case '3':
                        {
                            Console.Clear();
                            C();
                            break;
                        }
                }
            }
        }
    }
}
