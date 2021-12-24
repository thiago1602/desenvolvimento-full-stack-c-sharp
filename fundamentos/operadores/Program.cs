// See https://aka.ms/new-console-template for more information

using System;


namespace Operadores
{
   class Program
   {
       static void Main(string[] args)
       {

           var a = 7;
           var b = 3.0m;


        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);
        Console.WriteLine(1 + 2);
        Console.WriteLine(a * 80);

        var c = 10 - b;

        Console.WriteLine(c);

    /* Operadores de atribuição  */

        var d = 5;
        var e = 5;
        var f = 5;
        var g = 5;
        var h = 5;

        d +=2; // a = a +2;
        Console.WriteLine(d);

         e -=2; // b = b  - 2;
        Console.WriteLine(e);

         f *=2; 
        Console.WriteLine(f);

         g /=2; 
        Console.WriteLine(g);

         h %=2; // 
        Console.WriteLine(h);

        /* Operadores unários */

        var i = 5;
        var j = 5;

        // i++;
        // j --;
         Console.WriteLine(++i);
         Console.WriteLine(--j);

        /* Operadores de Comparação */
        var k = 2;
        var l = 3;
        var iguais = k == l;
        var diferentes = k != l;
        var maior = k > l;
        var menor = k < l;
        var maiorOuIgual = k >= l;
        var menorOuIgual = k <= l;
        Console.WriteLine(iguais);
        Console.WriteLine(diferentes);
        Console.WriteLine(maior);
        Console.WriteLine(menor);
        Console.WriteLine(maiorOuIgual);
        Console.WriteLine(menorOuIgual);

        /* Operadores Lógicos */

        var ativo = true;
        var m = 3;
        var n = 5;

        Console.WriteLine(!a > b);


       }
   }
}
