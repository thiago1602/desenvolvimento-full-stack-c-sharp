using System;


namespace Personagens
{
    public class Personagem
    {
        public string Nome { get; set;}
        public int Vida { get; set;}
        protected string Id { get; set; }
        public Personagem(string nome, int vida)
        {
            Nome = nome;
            Vida = vida;
        }
        public virtual void Atacar()
        {
            Console.WriteLine($"{Nome} atacou.");
        }
         public void Defender()
        {
            Console.WriteLine($"{Nome} defendeu.");
        }

        public abstract void AtacarEspecial();
        
    }
}