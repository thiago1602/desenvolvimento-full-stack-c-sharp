using System;
namespace Contas
{
    public class Conta
    {
        //Atributos
        public static double TaxaRendimento = 0.5f;
        public string Numero;
        public DateTime DataAbertura;
        public decimal Saldo;

        //Construtor
        public Conta()
        {
            Numero = "00552-2";
            DataAbertura = DateTime.Now;
            Saldo = 0;
        }

        public Conta(string numero, DateTime dataAbertura, decimal saldo)
        {
            Numero = numero;
            DataAbertura = dataAbertura;
            Saldo = saldo;
        }

        //Metodos
        public string ExibirExtrato()
        {
    

            return $"Conta N:   {Numero}{Environment.NewLine}" +
                   $"Data DA Abertura:   {DataAbertura.ToString("dd/MM/yyyy")} " +
                   $"Saldo:    {Saldo.ToString("C")}" +
            "---------------------------------------------";
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public void RealizarEmprestimo(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"O valor { valor } foi creditado e será debitado dentro de 30 dias");
        }

        public  void RealizarEmprestimo(decimal valor, int parcelas)
        {
            Console.WriteLine($"O valor { valor } foi creditado e será debitado {parcelas} vezes");

        }

        public static double CalcularRendimento(double capital, int meses)
        {
            return capital * Math.Pow(1 + TaxaRendimento, meses);
        }
    }
    }
}