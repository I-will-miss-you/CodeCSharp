using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region if
            int a = 5;
            int b = 10;
            int c = 5;


            if (c == 5) Console.WriteLine("c == 5");

            if (a == b)
                Console.WriteLine(a == b);
            else
                Console.WriteLine(a == b);


            if (a == b)
            {
                Console.WriteLine("a == b");
            }
            else if (a == c)
            {
                Console.WriteLine("a == c");
            }
            else
            {
                Console.WriteLine("a != b && a != c");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
