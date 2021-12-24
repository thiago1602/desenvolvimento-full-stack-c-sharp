// See https://aka.ms/new-console-template for more information
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[3];
            numeros[0] = 10;
            numeros[1] = 11;
            numeros[2] = 12;
            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);

            int[] pares = new int[3]{2, 4, 6};

            Console.WriteLine(pares[0]);
            Console.WriteLine(pares[1]);
            Console.WriteLine(pares[2]);

            int[] impares = new int[] {1, 3, 5, 7, 9};

            Console.WriteLine(impares[0]);
            Console.WriteLine(impares[1]);
            Console.WriteLine(impares[2]);
            Console.WriteLine(impares[3]);
            Console.WriteLine(impares[4]);

            string [] nomes = new [] {"Thiago", "Bruna", "Laissa"};

            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);

            var cidades = new [] {"Marilia", "Bauru"};
              Console.WriteLine(cidades[0]);
                Console.WriteLine(cidades[1]);


        }
    }
}
