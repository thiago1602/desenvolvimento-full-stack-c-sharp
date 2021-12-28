﻿// See https://aka.ms/new-console-template for more information
using System;

namespace Metodos
{
    class ContaCorrente
    {
        public string Numero;

        public decimal Saldo;

        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Numero: { Numero } | Saldo: { Saldo }");
        }

        public string ListarInformacoes()
        {
            return $"NUMERO: {Numero} | SALDO: {Saldo}";
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }


class Program{
    static void Main(string[] args)
    {
        var conta1 = new ContaCorrente();
        conta1.Numero = "001-002";
        conta1.Saldo = 0;
        //conta1.ImprimirInformacoes();
        Console.WriteLine(conta1.ListarInformacoes());
        conta1.Depositar(100);
        Console.WriteLine(conta1.ListarInformacoes());

    }
}
}
