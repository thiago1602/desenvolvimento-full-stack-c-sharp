// See https://aka.ms/new-console-template for more information using;
using System;

namespace For
{
    class Program
    {
        static void Main (string[] args)
        {
            var numeros = new [] {1, 10, 100, 1000};
            for(var indice = 0; indice < numeros.Length; indice++)
            {
                Console.WriteLine(numeros[indice]);
            }
        

        }
    }
}


