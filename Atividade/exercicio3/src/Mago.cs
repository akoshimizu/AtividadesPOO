using System;
using System.Collections.Generic;

namespace exercicio3.src
{
    public class Mago : Personagem
    {
        private List<string> magias = new List<string>();
        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base( nome, vida, mana, xp, inteligencia, forca, level)
        {   
        }

        public override void lvlUp()
        {
            Vida += 150;
            Mana += 200;
            Xp += 300;
            Inteligencia += 100;
            Forca += 30;
            Level += 1;
        }

        public override void Attack()
        {   Random rnd = new Random();
            int ataqueRandomico = rnd.Next(0,300); 
            int ataque = (Inteligencia*Level)+ataqueRandomico;
            Console.WriteLine($"Dano Ataque: {ataque}");
            Console.WriteLine($"Rnd: {ataqueRandomico}");
            Console.WriteLine();
        }

        public void aprenderMagia()
            {
                int i = Level;
                magias.Add($"Magia {i-1}");
                Console.WriteLine($"{i-1}ª magia adquirida!");
                Console.WriteLine();
            }
        
        public void mostrarMagias()
        {
            foreach (var item in magias)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}