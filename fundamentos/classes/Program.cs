// See https://aka.ms/new-console-template for more information
using System;

namespace Classes
{
    class Aluno
    {
        public string Nome;
        public int Idade;

    }


class Program{
    static void Main(string[] args)
    {
        var aluno1 = new Aluno();
        aluno1.Nome = "Thiago";
        aluno1.Idade = 26;
        


        Console.WriteLine(aluno1.Nome);
        Console.WriteLine(aluno1.Idade);

    }
}
}
