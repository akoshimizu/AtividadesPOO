using System;
using exercicio3.src;
using System.Collections.Generic;

namespace exercicio3
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base( nome, vida, mana, xp, inteligencia, forca, level)
        {
        }

       private List<string> habilidades = new List<string>();

        public override void lvlUp()
        {
            Vida += 400;
            Mana += 30;
            Xp += 300;
            Inteligencia += 30;
            Forca += 200;
            Level += 1;
        }

        public override void Attack()
        {   Random rnd = new Random();
            int ataqueRandomico = rnd.Next(0,300); 
            int ataque = (Forca*Level)+ataqueRandomico;
            Console.WriteLine($"Dano Ataque: {ataque}");
            Console.WriteLine($"Rnd: {ataqueRandomico}");
            Console.WriteLine();
        }           
        public void aprenderHabilidade()
        {
            int i = Level;
            habilidades.Add($"Habilidade {i-1}");
            Console.WriteLine($"{i-1}ª habilidade adquirida!");
            System.Console.WriteLine();
            //Console.WriteLine($"qnt: {habilidade.Count}");
        }

        public void mostrarHabilidades()
        {
            foreach (var item in habilidades)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }
    }
}