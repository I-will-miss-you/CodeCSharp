using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Aluno
    {
        //Fields
        private string nome;
        private int idade;


        //Properties
        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }



    }
}
