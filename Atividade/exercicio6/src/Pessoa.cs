using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio6.src
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

        public void Apresentar(List<Pessoa> pessoas)
        {
            var resultado = from a in pessoas
                            orderby a.Idade 
                            select new {a.Nome, a.Idade};

            foreach (var item in resultado)
            {
                Console.WriteLine($"{item.Nome} {item.Idade}");
            }
        }

        public void Procurar(List<Pessoa> pessoas)
        {
            var resultado = from a in pessoas
                            orderby a.Idade 
                            select new {a.Nome, a.Idade};

            foreach (var item in resultado)
            {
                if(item.Nome == "Jessica")
                Console.WriteLine($"{item.Nome} {item.Idade}");
            }
        }

        public void excluirMenor(List<Pessoa> pessoas)
        {
            for (int i = 0; i < pessoas.Count; i++)
            {
                if(pessoas[i].Idade<18)
                {
                    pessoas.Remove(pessoas[i]);
                }
            }
        }
    }
}