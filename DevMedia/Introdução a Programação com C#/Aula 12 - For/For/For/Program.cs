using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n Print vertical:");
            string nome = "Code26u4r60";
            for (int i = 0; i < nome.Length ; i++)
            {
                Console.WriteLine(" " + nome[i]);
            }

            Console.WriteLine("\n Soma:");
            for (int i = 0 , j = 10; i <= j ; i++ , j--)
            {
                Console.WriteLine(" {0,2} + {1,2} = {2,2}",i,j,i+j);
            }

            Console.WriteLine("\n Matrix:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" {0,2}",i+j);
                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }

    }
}
