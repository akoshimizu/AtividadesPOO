using System;
using System.Collections.Generic;

namespace exercicio3.src
{
    public class Personagem
    {
        protected string Nome { get; set; }
        protected int Vida { get; set; }
        protected int Mana { get; set; }
        protected float Xp { get; set; }
        protected int Inteligencia { get; set; }
        protected int Forca { get; set; }
        protected int Level { get; set; }
        
        public static int totalDePersonagens = 0;
        
        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            this.Nome = nome;
            this.Vida = vida;
            this.Mana = mana;
            this.Xp = xp;
            this.Inteligencia = inteligencia;
            this.Forca = forca;
            this.Level = level;
            Personagem.totalDePersonagens++;
        }
        
        public int SomaPersonagem()
        {
            return Personagem.totalDePersonagens +1;
        }
       

        public Personagem()
        {
        }

        public virtual void lvlUp()
        {
            Vida += 150;
            Mana += 30;
            Xp += 300;
            Inteligencia += 30;
            Forca += 30;
            Level += 1;
        }

        public virtual void Attack()
        {   Random rnd = new Random();
            int ataqueRandomico = rnd.Next(0,300); 
            int ataque = (Forca*Level)+ataqueRandomico;
            Console.WriteLine($"Dano Ataque: {ataque}");
            Console.WriteLine();
        }

        public void Atributos()
        {
            Console.WriteLine($"Nome:           {Nome}");
            Console.WriteLine($"Vida:           {Vida}");
            Console.WriteLine($"Mana:           {Mana}");
            Console.WriteLine($"Xp:             {Xp}");
            Console.WriteLine($"Inteligencia:   {Inteligencia}");
            Console.WriteLine($"Força:          {Forca}");
            Console.WriteLine($"Level:          {Level}");
            Console.WriteLine(); 
        }
    }
}