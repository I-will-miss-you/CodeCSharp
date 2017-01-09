using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBreak
{
    class Program
    {
        enum dia_semana { segunda, terça, quarta, quinta, sexta, sabado, domingo };

        static void Main(string[] args)
        {

            #region operador ternario
            int idade = 19;
            bool maior_idade = (idade >= 18) ? true : false;
            #endregion

            #region switch dia da semana
            //Console.WriteLine("Inserir um numero de 1 a 7");
            //int mes = int.Parse(Console.ReadLine());

            //switch (mes)
            //{
            //    case 1:
            //        Console.WriteLine(dia_semana.segunda);
            //        break;
            //    case 2:
            //        Console.WriteLine(dia_semana.terça);
            //        break;
            //    case 3:
            //        Console.WriteLine(dia_semana.quarta);
            //        break;
            //    case 4:
            //        Console.WriteLine(dia_semana.quinta);
            //        break;
            //    case 5:
            //        Console.WriteLine(dia_semana.sexta);
            //        break;
            //    case 6:
            //        Console.WriteLine(dia_semana.sabado);
            //        break;
            //    case 7:
            //        Console.WriteLine(dia_semana.domingo);
            //        break;
            //    default:
            //        Console.WriteLine("dia de marte");
            //        break;
            //}
            #endregion

            #region dia de trabalho
            Console.WriteLine("Dia da semana (1 - 7)");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case (int)dia_semana.segunda:
                case (int)dia_semana.terça:
                case (int)dia_semana.quarta:
                case (int)dia_semana.quinta:
                case (int)dia_semana.sexta:
                    Console.WriteLine("Vai trabalhar... ");
                    break;
                case (int)dia_semana.sabado:
                case (int)dia_semana.domingo:
                    Console.WriteLine(" Se ela dança eu danço... falei com a minina so pra a vê dançar...");
                    break;
                default:
                    Console.WriteLine("Esse dia não existe pá...");
                    break;
            }
            #endregion
            Console.ReadLine();
        }
    }
}
