using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio4.src
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public Pessoa()
        {
        }
        int maisVelhoIdade = 0;
        string maisVelhoNome;
        public void Apresentar(List<Pessoa> pessoas)
        {
            var resultado = from a in pessoas
                            orderby a.Idade 
                            select new {a.Nome, a.Idade};

            foreach (var item in resultado)
            {
                if(maisVelhoIdade<item.Idade)
                {
                    maisVelhoIdade = item.Idade;
                    maisVelhoNome = item.Nome;
                }
                Console.WriteLine($"{item.Nome} {item.Idade}");
            }
            Console.WriteLine("\nPessoa mais velha:");
            Console.WriteLine($"{maisVelhoNome} {maisVelhoIdade}");
        }
    }
}