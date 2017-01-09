using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    public class Aluno
    {
        public Aluno()
        {
            Console.WriteLine("Aluno Constructor");
        }

        ~Aluno()
        {
            Console.WriteLine("Aluno Destructor");
        }
    }
}
