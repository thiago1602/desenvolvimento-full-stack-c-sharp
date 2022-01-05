// See https://aka.ms/new-console-template for more information
using System;
using Financeiro;
using RH;
using Orcamento;

namespace Namespace
{
   class Program
   {
       static void Main(string[] args)
       {
           var  contaPagar = new ContaPagar();
           var  contaReceber = new ContaReceber();
           var funcionario = new Funcionario();
           var folhaPagamento = new FolhaPagamento();
        Console.WriteLine("Hello, World!");

       }
   }
}