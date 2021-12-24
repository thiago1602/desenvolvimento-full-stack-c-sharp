// See https://aka.ms/new-console-template for more information
using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            var indice = 1;
            var versoes = new [] {"1.0", "1.1", "2.0", "3.0"};
            while (indice < versoes.Length)
            {
             Console.WriteLine(versoes[indice]);
             indice++;

             var contador = 10;
             var opcao= "";

            do
            {
                Console.WriteLine("Digite uma opção");
                Console.WriteLine("1 - Saque | 2- Depósito | 3- Sair");
                opcao = Console.ReadLine();
                
             switch (opcao)
            {
                case "1":
                Console.WriteLine("Saque realizado");
                break;
                case "2":
                Console.WriteLine("Deposito realizado");
                break;
            }

            }
            while (opcao != "0");

    }
}

    }
}