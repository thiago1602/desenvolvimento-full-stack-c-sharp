// See https://aka.ms/new-console-template for more information
using System;
using Personagens;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var personagem = new Personagem("Cavaleiro", 100);
            var cavaleiro = new Cavaleiro("Aragorn", 100);
            var arqueiro = new Arqueiro("Legolas", 100);
            var mago = new Mago("Mestre", 100);

            cavaleiro.Atacar();
            cavaleiro.Defender();

            arqueiro.Atacar();
            arqueiro.Defender();

            mago.Atacar();
            mago.Defender();
            
            cavaleiro.AtacarEspecial();
            

            arqueiro.AtacarEspecial();
            

            mago.AtacarEspecial();
            
           

        }
    }
}
