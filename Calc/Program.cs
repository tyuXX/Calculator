using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program execution starts from here
            Console.WriteLine("Total Arguments: {0}", args.Length);

            Console.Write("Arguments: ");

            foreach (var arg in args)
                Console.Write(arg + ", ");
            Console.Read();
        }
    }
}
