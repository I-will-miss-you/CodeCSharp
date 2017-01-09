using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string numeros = "one,two,three";
            numeros += ",four";
            numeros += ",six";
            Console.WriteLine(numeros);
            Console.WriteLine(numeros.EndsWith("ive"));
            Console.WriteLine(numeros.Equals("lista"));
            Console.WriteLine(numeros.IndexOf("two"));
            numeros = numeros.Insert(numeros.IndexOf("six"), "five,");
            Console.WriteLine(numeros);
            Console.WriteLine(numeros.Length);
            numeros = numeros.Remove(numeros.IndexOf("five"), (numeros.IndexOf("six") - numeros.IndexOf("five")));
            Console.WriteLine(numeros);
            numeros = numeros.Replace("six", "five");
            Console.WriteLine(numeros);
            string[] num = numeros.Split(',');
            foreach (var n in num)
            {
                Console.WriteLine(n);
            }
            
             
            //StringBuilder num = new StringBuilder();
            //num.Append("one,");
            //num.Append("two,");
            //num.Append("three,");
            //num.Append("four,");
            //num.Append("five");
            //Console.WriteLine(num.ToString());
            //Console.WriteLine(num.ToString().IndexOf("two"));



            Console.ReadLine();
        }
    }
}
