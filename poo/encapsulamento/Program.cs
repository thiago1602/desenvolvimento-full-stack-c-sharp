// See https://aka.ms/new-console-template for more information
using System;
using RH;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario("Thiago", "42275687987");
           funcionario.CPF("111.111.111-11");
            Console.WriteLine(funcionario.CPF);
           

        }
    }
}
