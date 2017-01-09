using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;
            int c = 10;

            int add = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;
            int res = a % b;

            Console.WriteLine("add {0}", add);
            Console.WriteLine("sub {0}", sub);
            Console.WriteLine("mul {0}", mul);
            Console.WriteLine("div {0}", div);
            Console.WriteLine("res {0}", res);

            int inc = 10;
            int dec = 10;
            Console.WriteLine("pre-inc {0}", ++inc);//pre-incrementa uma unidade
            Console.WriteLine("pre-dec {0}", --dec);//pre-decrementa uma unidade
            inc = 10;
            dec = 10;
            Console.WriteLine("pos-inc {0}", inc++);//pos-incrementa uma unidade
            Console.WriteLine("pos-dec {0}", dec--);//pos-decrementa uma unidade
            Console.WriteLine("pos-inc {0}", inc);//pos-incrementa uma unidade
            Console.WriteLine("pos-dec {0}", dec);//pos-decrementa uma unidade

            /* Comparação*/
            bool igual = (a == b) ? true : false;
            bool diferente = (a != b) ? true : false;
            bool maior = (a > b) ? true : false;
            bool menor = (a < b) ? true : false;
            bool maiorIgual = (a >= b) ? true : false;
            bool menorIgual = (a <= b) ? true : false;

            Console.WriteLine("\n a = {0} e b = {1}", a, b);
            Console.WriteLine("A igual B-> {0}", igual);
            Console.WriteLine("A diferente B-> {0}", diferente);
            Console.WriteLine("A maior B -> {0}", maior);
            Console.WriteLine("A menor B -> {0}", menor);
            Console.WriteLine("A maior ou igual B-> {0}", maiorIgual);
            Console.WriteLine("A menor ou igual B-> {0}", menorIgual);

            Console.WriteLine("\nOperadores Logícos e Condicionais:");
            /* Operadores Logícos*/
            //XOR - Lôgico Exclusivo: têm que uma ou outra condição ser verdadeira e nunca as duas falsas ou verdadeiras.
            // 0 0 -> false
            // 1 0 -> true
            // 0 1 -> true
            // 1 1 -> false
            if (a > b ^ a > c)
                Console.WriteLine("A > B ^ A > C -> {0}", a > b ^ a > c);

            /* Operadores Condicionais*/
            /* AND : ambas a condições têm de ser verdadeiras
             * 0 0 -> false
             * 0 1 -> false
             * 1 0 -> false
             * 1 1 -> true
             */
            if (a > b && a == c)
                Console.WriteLine("A > B && A == C -> {0}", a > b && a == c);

            /* OR : basta uma das condições ser verdadeira...
             * 0 0 -> false
             * 0 1 -> true
             * 1 0 -> true
             * 1 1 -> true
             */
            if (a > b || c > b)
                Console.WriteLine("A > B || C > B -> {0}", a > b || c > b);

            Console.ReadLine();
        }
    }
}
