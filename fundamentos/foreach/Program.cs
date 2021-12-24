// See https://aka.ms/new-console-template for more information using;
using System;

namespace Foreach
{
    class Program
    {
        static void Main (string[] args)
        {
            var numeros = new [] {1, 10, 100, 1000};
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}


