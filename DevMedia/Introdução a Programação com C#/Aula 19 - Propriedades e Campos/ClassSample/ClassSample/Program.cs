using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.Nome = "João";
            a1.Idade = 30;

            Aluno a2 = new ClassSample.Aluno();
            a2.Nome = "Lauro";
            a2.Idade = 18;

            Console.WriteLine(a1.Nome);
            Console.WriteLine(a2.Nome);


            Console.ReadLine();
        }
    }
}
