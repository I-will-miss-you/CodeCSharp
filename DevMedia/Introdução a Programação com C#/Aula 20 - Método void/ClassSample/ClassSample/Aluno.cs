using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Aluno
    {
        //Fieds
        private string nome;
        private int idade;

        public Aluno(){}
        public Aluno(string _nome, int _idade)
        {
            Nome = _nome;
            idade = _idade;
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

        public void limpar()
        {
            this.Nome = null;
            this.idade = 0;
        }


        
    }
}
