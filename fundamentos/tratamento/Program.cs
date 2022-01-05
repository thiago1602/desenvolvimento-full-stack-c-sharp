// See https://aka.ms/new-console-template for more information
using System;


namespace Tratamento
{
   class Program
   {
       static void Main(string[] args)
       {
           try
           {
               var nomes = new [] {"Thiago", "Laissa"};
               for(var indice = 0; indice <= nomes.Length; indice++){
                   Console.WriteLine(nomes[indice]);
               }
           }
           catch (Exception ex)
           {
               Console.WriteLine("Ocorreu um erro: " + ex.Message);
               
           }

           finally
           {
               Console.WriteLine("Programa encerrado.");
           }
        

       }
   }
}
