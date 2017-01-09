using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] idades = new int[3]; //array de inteiros (idade) com 3 posições 
            //idades[0] = 10;
            //idades[1] = 20;
            //idades[2] = 30;
            ////idades[5] = 50; //esta atribuição esta errada pois o array criado só têm 3 posições

            //int[,] matrix = new int[3,3];
            //matrix[0, 0] = 0;
            //matrix[0, 1] = 1;
            //matrix[0, 2] = 2;
            //matrix[1, 0] = 3;
            //matrix[1, 1] = 4;
            //matrix[1, 2] = 5;
            //matrix[2, 0] = 6;
            //matrix[2, 1] = 7;
            //matrix[2, 2] = 8;
            //Console.WriteLine(matrix[1,1]);

            //string[] dias = new string[] { "seg", "ter", "qua", "qui", "sex", "sab", "dom" };
            //string[] dia = { "seg", "ter", "qua", "qui", "sex", "sab", "dom" }; //vale o mesmo que a anterior declaração
            //Console.WriteLine("No {0} não se trabalha.", dia.GetValue(5));
            //Console.WriteLine("Numero de dias por semana : {0}",dia.Length);

            ArrayList meses = new ArrayList(); //pode receber qualquer tipo de dados
            meses.Add("Janeiro");
            meses.Add(1);
            meses.Add(1.0);
            meses.Add('j');
            Console.WriteLine("{0} {1}",meses[0],meses[1]);

            List<string> nome = new List<string>();
            nome.Add("João");
            //nome.Add(1);//errado, só aceito valores do tipo pre definido
            nome.Add("Ana");
            nome.Add("Joaquim");
            Console.WriteLine(nome[2]);

            Console.ReadLine();
        }
    }
}
