using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula14
{
    class Program
    {
        public struct Livro
        {
            public string titulo;
            public string autor;
            public int codigo;
            public int anoPublicacao;
        }

        static void Main(string[] args)
        {
            //Livro l1 = new Livro();
            Livro l1;
            l1.codigo = 1;
            l1.autor = "Machado de Assis";
            l1.titulo = " Dom Casmurro";
            l1.anoPublicacao = 1940;

            Livro l2;
            l2.codigo = 1;
            l2.autor = "Jorge Amado";
            l2.titulo = " Gabriela";
            l2.anoPublicacao = 1965;

            List<Livro> livros = new List<Livro>(); 
            livros.Add(l1);
            livros.Add(l2);

            foreach (Livro item in livros)
            {
                Console.WriteLine("Livro Código: " + item.codigo.ToString());
                Console.WriteLine("Titulo: " + item.titulo);
                Console.WriteLine("Autor: " + item.autor);
                Console.WriteLine("Ano Publicação: " + item.anoPublicacao.ToString());
                Console.WriteLine("-------------------------------------------------");
            }
        




            Console.ReadLine();

        }
    }
}
