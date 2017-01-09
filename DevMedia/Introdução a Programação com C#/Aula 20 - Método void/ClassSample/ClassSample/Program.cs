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
            a1.Nome = "Pedro";
            a1.Idade = 30;
            Console.WriteLine(a1.Nome);

            Aluno a2 = new ClassSample.Aluno();
            a2.Nome = "Lauro";
            a2.Idade = 18;
            Console.WriteLine(a2.Nome);

            Aluno a3 = new Aluno("Alberto", 25);
            Console.WriteLine(a3.Nome);

            a1.limpar();
           Console.WriteLine(a1.Nome);


            Console.ReadLine();
        }
    }
}
