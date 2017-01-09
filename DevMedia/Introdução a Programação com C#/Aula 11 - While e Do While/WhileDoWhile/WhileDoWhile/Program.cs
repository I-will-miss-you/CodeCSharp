using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            Console.WriteLine("Do - While");
            do
            {
                Console.WriteLine(a);
            } while (a++ < b);

            Console.WriteLine("****************");

            Console.WriteLine("While");
            a = 1;
            while (a++ < b)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }

    }
}
