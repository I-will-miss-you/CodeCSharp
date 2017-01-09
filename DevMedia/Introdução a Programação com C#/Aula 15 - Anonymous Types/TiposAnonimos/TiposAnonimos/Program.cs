using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable
            int? i = null; //As variáveis primitivas precisão de "?" para poderem receber um valor null
            char? c = null;

            string s = null; //a class string não precisa

            /*************************************************/
            var valor = new { idade = 18, nome = "Luis" };
            var valores = new[] { new {idade = 18, nome = "Luis"}, new {idade = 19, nome = "Andre"}};
            Console.WriteLine(valor);


            foreach (var item in valores)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
