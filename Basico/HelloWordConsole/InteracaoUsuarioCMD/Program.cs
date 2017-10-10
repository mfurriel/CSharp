using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteracaoUsuarioCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esse é um programa que interage de maneira simples com o usuario");
            Console.WriteLine("Qual é o seu nome?");

            String usuario = Console.ReadLine();

            Console.WriteLine("Seja bem vindo " + usuario);
            Console.WriteLine("Qual é a sua idade?");

            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Legal, você nasceu entre " + ((DateTime.Now.Year - idade) -1) + " e " + (DateTime.Now.Year - idade));
            Console.WriteLine("Desculpe, ainda não sou suficientemente inteligente para acertar a data correta ='(");
            Console.WriteLine("Você poderia me ensinar?");
            Console.WriteLine("Baixe e altere o meu código fazendo com que eu acerte a data correta do seu nascimento =D");
            Console.WriteLine("Até logo!");
            Console.ReadLine();

        }
    }
}
