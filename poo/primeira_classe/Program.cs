// See https://aka.ms/new-console-template for more information
using System;
using Contas;

namespace Primeira_classe
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta(); //cria uma nova instancia da classe
            
            Console.WriteLine(conta.ExibirExtrato());

            var conta2 = new Conta("005522", DateTime.Now, 100);

            Console.WriteLine(conta2.ExibirExtrato());
            
            /* conta.Numero = "001";
            conta.DataAbertura = DateTime.Today;
            conta.Saldo = 0;
            
           conta.RealizarEmprestimo(200, 10);
           Console.WriteLine(conta.ExibirExtrato());


           Console.WriteLine(Conta.TaxaRendimento);
           Console.WriteLine(Conta.CalcularRendimento(100, 12)); */
        }
    }
}

