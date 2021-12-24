// See https://aka.ms/new-console-template for more information
using System;


namespace TiposDateTime
{
   class Program
   {
       static void Main(string[] args)
       {

        var hoje = DateTime.Today;
        var agora = DateTime.Now;
        var data1 = new DateTime(2021, 12, 23);
        var data2 = new DateTime(2021, 12, 23, 11, 25, 30);
        var data3 = DateTime.Parse("23/12/2021 20:58:21");

        Console.WriteLine(hoje);
        Console.WriteLine(agora);
        Console.WriteLine(data1);
        Console.WriteLine(data2);
        Console.WriteLine(data3);
        Console.WriteLine(data3.Day);
        Console.WriteLine(data3.Month);
        Console.WriteLine(data3.Year);
        Console.WriteLine(data3.Hour);
        Console.WriteLine(data3.Minute);
        Console.WriteLine(data3.Second);
        Console.WriteLine(data3.AddDays(10));
        Console.WriteLine(data3.AddMonths(-1));
        Console.WriteLine(data3.ToLongDateString());
        Console.WriteLine(data3.ToLongTimeString());
        Console.WriteLine(data3.ToShortTimeString());

       }
   } 
}




