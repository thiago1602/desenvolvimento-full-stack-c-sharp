using System;

namespace Personagens
{
    public class Arqueiro : Personagem
    {
        public Arqueiro(string nome, int vida) : base(nome, vida)
        {
         
        }
           public override void Atacar()
        {
            Console.WriteLine($"{Nome} atacou com Arco e flexa."););
        }

        public override void AtacarEspecial()
        {
            Console.WriteLine($"{Nome} atacou especial com arco e flexa");
        }
    }
}