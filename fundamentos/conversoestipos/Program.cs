// See https://aka.ms/new-console-template for more information
using System;

namespace ConversoesTipos
{
   class Program
   {
       static void Main(string[] args)
       {
           int ano = 2021;
           double ano2 = ano;

           decimal taxa = 12.98m;
           DateTime data = DateTime.Now;
           string taxa2 = taxa.ToString();
           string data2 = data.ToString();

           string resposta = "12";
           int idade = int.Parse(resposta);
           int idade2 = Convert.ToInt32(resposta);


        Console.WriteLine(idade2);

       }
   } 
}
