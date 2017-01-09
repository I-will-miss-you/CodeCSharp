using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura
{
    class Program
    {
        public struct Autor
        {
            public string nome;
            public string mail;
        }

        public struct Livro
        {
            public string titulo;
            public Autor autor;
            public int codigo;
            public int anoPublicacao;
        }



        static void Main(string[] args)
        {
            Autor a1 = new Autor();
            Autor a2 = new Autor();

            a1.nome = "Machado de Assis";
            a1.mail = "machado@mail.com";

            a2.nome = "Jorge Amado";
            a2.mail = "jorge@mail.com";

            Livro l1 = new Livro();
            l1.codigo = 1;
            l1.autor = a1;
            l1.titulo = "Dom Casmurro";
            l1.anoPublicacao = 1940;

            Livro l2 = new Livro();
            l2.codigo = 2;
            l2.autor = a2;
            l2.titulo = "Gabriela";
            l2.anoPublicacao = 1965;

            Console.WriteLine("Autor: " + l1.autor.nome +"\nTitulo do livro: "+l1.titulo);

            Console.ReadLine();
        }
    }
}
