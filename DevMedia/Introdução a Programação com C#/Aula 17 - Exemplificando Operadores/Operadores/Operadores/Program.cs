using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor 1: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Valor 2: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Soma : {0}", a + b);
            Console.WriteLine("Subtração : {0}", a - b);
            Console.WriteLine("Multiplicação : {0}", a * b);
            Console.WriteLine("Divisão : {0}",(b>0)?(a / b).ToString():"Erro - Divisião por zero");
            
            
            Console.ReadLine();
        }
    }
}
