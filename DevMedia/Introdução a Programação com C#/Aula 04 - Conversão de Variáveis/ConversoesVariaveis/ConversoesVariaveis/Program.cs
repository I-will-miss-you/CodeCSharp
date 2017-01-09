using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesVariaveis
{
    class Program
    {
        enum acessorio { Sapato, Bolsa = 5, Cinto, Carteira, Colar };
        static void Main(string[] args)
        {
            //Estrutura enum - enumeração
            //Console.WriteLine("enum[{0}] tem o  valor de {1}", acessorio.Bolsa, (int)acessorio.Bolsa);

            //Implicit Numeric Conversions
            //exemplos~:
            //sbyte sb = 12;
            //short sh = sb;
            //int i = sh;
            //long l = i;
            //float f = l;
            //double d = f;
            //Console.WriteLine("Valor de final = {0} ",d);

            //Explicit Numeric Conversions
            //exemplos:
            //float f2 = 21.98888f;
            //decimal dec = (decimal)f2;
            //double d2 = (double)dec;
            //int i2 = (int)d2;
            //short sh2 = (short)i2;
            //Console.WriteLine("Neste tipo d econversão pode ocorrer perdas como é o caso.");
            //Console.WriteLine("Valor inicial {0} : valor final {1}.",f2,sh2);


            //Uso do PARSE
            //exemplo:

            //Console.WriteLine("Idade: ");
            //string idade = Console.ReadLine();
            //if(int.Parse(idade) >= 18)
            //    Console.WriteLine("Maior de idade");
            //else
            //    Console.WriteLine("Menor de idade");

            //OU ...

            //Console.WriteLine("Idade: ");
            //int idade = int.Parse(Console.ReadLine());

            //if (idade >= 18)
            //    Console.WriteLine("Maior de idade");
            //else
            //    Console.WriteLine("Menor de idade");


            //TryParse
            //float altura;
            //bool ok = float.TryParse("175,8",out altura);
            //Console.WriteLine("bool = {0}  :: altura = {1}",ok,altura);

            //Convert
            //DateTime data = new DateTime(1984, 11, 19);
            //string data_nascimento = Convert.ToString(data);
            //Console.WriteLine(data_nascimento);


            Console.ReadLine();
        }
    }
}
