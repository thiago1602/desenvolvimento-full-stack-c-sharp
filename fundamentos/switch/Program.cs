// See https://aka.ms/new-console-template for more information
using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Selecione a opção: ");
            var opcao = Console.ReadLine();


            switch (opcao)
        {
            case "1": 
            Console.WriteLine("Seu saldo é de 100 reais");
            break;
            case "2": 
            Console.WriteLine("Informe o valor do deposito");
            break;
            case "3": 
            Console.WriteLine("Informe o valor do saque");
            break;

}
        }
    }
}



