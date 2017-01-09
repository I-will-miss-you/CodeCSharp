using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Documentação: https://msdn.microsoft.com/en-us/library/s1ax56ch.aspx

            //Valores Inteiros
            Console.WriteLine("\nInteiros:");
            sbyte sb_min = sbyte.MinValue;
            Console.WriteLine("sbyte min: " + sb_min);
            sbyte sb_max = sbyte.MaxValue;
            Console.WriteLine("sbyte max: " + sb_max);
            
            short sh_min = short.MinValue;
            Console.WriteLine("\nshort min: " + sh_min);
            short sh_max = short.MaxValue;
            Console.WriteLine("short max: " + sh_max);

            ushort ush_min = ushort.MinValue;
            Console.WriteLine("\nushort min: " + ush_min);
            ushort ush_max = ushort.MaxValue;
            Console.WriteLine("ushort max: " + ush_max);

            int i_min = int.MinValue;
            Console.WriteLine("\nint min: " + i_min);
            int i_max = int.MaxValue;
            Console.WriteLine("int max: " + i_max);

            uint ui_min = uint.MinValue;
            Console.WriteLine("\nuint min: " + ui_min);
            uint ui_max = uint.MaxValue;
            Console.WriteLine("uint max: " + ui_max);

            long l_min = long.MinValue;
            Console.WriteLine("\nlong min: " + l_min);
            long l_max = long.MaxValue;
            Console.WriteLine("long max: " + l_max);

            ulong ul_min = ulong.MinValue;
            Console.WriteLine("\nulong min: " + ul_min);
            ulong ul_max = ulong.MaxValue;
            Console.WriteLine("ulong max: " + ul_max);

            //Valores decimais
            Console.WriteLine("\nDecimais:");
            float f_min = float.MinValue;
            Console.WriteLine("Float min: " + f_min);
            float f_max = float.MaxValue;
            Console.WriteLine("Float max: " + f_max);

            double d_min = double.MinValue;
            Console.WriteLine("\nDouble min: " + d_min);
            double d_max = double.MaxValue;
            Console.WriteLine("Double max: " + d_max);

            decimal dec_min = decimal.MinValue;
            Console.WriteLine("\nDecimal min: " + dec_min);
            decimal dec_max = decimal.MaxValue;
            Console.WriteLine("Decimal max: " + dec_max);

            //Boolean
            Console.WriteLine("\nBoolean:");
            bool verdade = true;
            Console.WriteLine("3 == 3 : " + verdade);
            bool falso = false;
            Console.WriteLine("3 == 4 : " + falso);

            //Texto
            Console.WriteLine("\nTexto:");
            char ch = 'a';
            Console.WriteLine("Exemplo de Char : " + ch);
            string str = "Ola mundo";
            Console.WriteLine("Exemplo de string : " + str);


            Console.ReadKey();
        }
    }
}
