using System;
using System.Collections.Generic;
using exercicio3.src;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago personagem2 = new Mago("Mago", 500, 100, 0, 50, 100, 1);
            

            Guerreiro personagem3 = new Guerreiro("Guerreiro", 500, 100, 0, 50, 100, 1);

            personagem2.Atributos();
            personagem2.Attack();
            personagem2.lvlUp();
            personagem2.aprenderMagia();
            personagem2.lvlUp();
            personagem2.aprenderMagia();
            personagem2.Atributos();
            personagem2.Attack();
            personagem2.mostrarMagias();            

            personagem3.Atributos();
            personagem3.Attack();
            personagem3.lvlUp();
            personagem3.aprenderHabilidade();
            personagem3.lvlUp();
            personagem3.aprenderHabilidade();
            personagem3.Atributos();
            personagem3.Attack();
            personagem3.mostrarHabilidades();

            
            Console.WriteLine($"Total de personagens criados: {Personagem.totalDePersonagens}");
            
            Console.ReadKey();
        }
    }
}
