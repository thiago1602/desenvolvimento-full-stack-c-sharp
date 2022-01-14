﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeVSREferencesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Passagem por valor
            /* int numero1 = 3;
             int numero2 = numero1;
             numero1 = 5;

             Console.WriteLine("numero1 = {0}, numero2 = {1}", numero1, numero2);
             Console.ReadKey();

             //Passagem por referencia
             Teste teste1 = new Teste();
             teste1.Quantidade = 3;
             Teste teste2 = teste1;
             teste1.Quantidade = 5;
             Console.WriteLine("teste1.Quantidade = {0}, teste2.Quantidade = {1}", teste1.Quantidade, teste2.Quantidade);
             Console.ReadKey(); */

            Teste teste1 = new Teste();
            teste1.Quantidade = 3;
            teste1.testePai = new Teste();
            Console.WriteLine("Quantidade é {0}", teste1.Quantidade);
            Console.WriteLine("Quantidade do teste pai {0}", teste1.testePai.Quantidade);
            Console.ReadKey();

        }
    }

    class Teste
    {
        public int Quantidade;
        public Teste testePai;
    }
}
