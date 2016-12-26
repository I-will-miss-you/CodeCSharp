using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {

           /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
           */

            /*
            //int[] numbers = new int[]{ 4, 8, 15, 16, 23, 42 };         
            int[] numbers = { 4, 8, 15, 16, 23, 42 };

        
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
           */


            /*
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };
            
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */
            /*
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
            */

            string zig = "You can get what want out of life if you help"+
                " enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();

        }
    }
}
