// See https://aka.ms/new-console-template for more information

using System;

namespace TipoString
{
   class Program
   {
       static void Main(string[] args)
       {

           var nome = "Thiago";
           var sobrenome = "Moraes";
           var nomeCompleto = nome + sobrenome;
           var nomeCompleto2 = $"{ nome } { sobrenome }";


        Console.WriteLine(nomeCompleto2.ToUpper());
        Console.WriteLine(nomeCompleto2.ToLower());
        Console.WriteLine(nomeCompleto.Substring(4));
        Console.WriteLine(nomeCompleto.Contains('o'));
        Console.WriteLine(nomeCompleto.StartsWith("P"));
        Console.WriteLine(nomeCompleto.EndsWith("H"));
        Console.WriteLine(nomeCompleto.IndexOf('a'));
        Console.WriteLine(nomeCompleto.LastIndexOf('a'));


       }
   } 
}
