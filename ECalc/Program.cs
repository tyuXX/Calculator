using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Math;

namespace ECalc
{
    static class Program
    {
        static List<BigInteger> prm = new List<BigInteger> { 2,3,5,7 };
        static void C()
        {
            Console.WriteLine("ECalc Made By [tyuXX]\n\n");
        }
        static void fp(BigInteger st)
        {
            BigInteger i = prm[(prm.Count - 2)];
            while (true)
            {
                bool c = true;
                foreach (BigInteger s in prm)
                {
                    if (s > i)
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
                if (c)
                {
                    prm.Add(i);
                }
                if (i >= st)
                {
                    break;
                }
                i++;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                BigInteger ans = 0, n1 = 0, n2 = 0;
                Decimal ads = 0M, d1 = 0M, d2 = 0M;
                Double aos = 0, o1 = 0, o2 = 0;
                Complex acs = 0, c1 = 0, c2 = 0;
                Console.Clear();
                C();
                Console.WriteLine("Options:\n[1]-Integer's\n[2]-Decimal's\n[3]-Complex's");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        {
                            Console.Clear();
                            C();
                            Console.WriteLine("Options:\n[1]-Integer Addition\n[2]-Integer Subtraction\n[3]-Integer Multiplication\n[4]-Integer Division\n[5]-Integer Moderation\n[6]-Integer Exponent\n[7]-Integer GCD\n[8]-Integer LCM\n[9]-Integer Percentage");
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
                                case '7':
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
                                            if (n1 > n2) { fp(n2); }
                                            if (n1 < n2) { fp(n1); }
                                            int ii = 0;
                                            BigInteger ni = 2;
                                            while (!((n1<1)&&(n2<1)))
                                            {
                                                if((n1 == ni)||(n2 == ni))
                                                {
                                                    ans = 1;
                                                    break;
                                                }
                                                else if(((n1%ni) == 0)&& ((n2%ni)== 0))
                                                {
                                                    if(ans == 0)
                                                    {
                                                        ans = ni;
                                                    }
                                                    else
                                                    {
                                                        ans *= ni;
                                                    }
                                                }
                                                else
                                                {
                                                    ii++;
                                                    ni = prm[ii];
                                                }
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
                                case '8':
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
                            }
                            break;
                        }
                    case '2':
                        {
                            Console.Clear();
                            C();
                            Console.WriteLine("Options:\n[1]-Decimal Addition\n[2]-Decimal Subtraction\n[3]-Decimal Multiplication\n[4]-Decimal Division\n[5]-Decimal Moderation\n[6]-Decimal Exponent\n[7]-Double Square Root\n[8]-Decimal Percentage");
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
                                case '7':
                                    {
                                        try
                                        {
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 1:\n");
                                            Double.TryParse(Console.ReadLine().Replace('.', ','), out o1);
                                            Console.Clear();
                                            C();
                                            aos = Sqrt(o1);
                                            Console.WriteLine(("Answer is:" + aos + "\nPress Any Key To Continue").Replace(',', '.'));
                                            aos = 0;
                                            o1 = 0;
                                            o2 = 0;
                                            Console.ReadKey();
                                        }
                                        catch (Exception) { }
                                        break;
                                    }
                                case '8':
                                    {
                                        try
                                        {
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 1:\n");
                                            Decimal.TryParse(Console.ReadLine(), out d1);
                                            Console.Clear();
                                            C();
                                            Console.WriteLine("Number 2:\n");
                                            Decimal.TryParse(Console.ReadLine(), out d2);
                                            Console.Clear();
                                            C();
                                            ads = d1 / 100;
                                            ads *= d2;
                                            Console.WriteLine("Answer is:" + ads + "\nPress Any Key To Continue");
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
                            Console.WriteLine("[1]-Home");
                            switch (Console.ReadKey().KeyChar)
                            {
                                case '1':
                                    {
                                        break;
                                    }
                            }
                            Console.Clear();
                            C();
                            break;
                        }
                }
            }
        }
    }
}
