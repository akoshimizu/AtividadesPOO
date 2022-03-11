using System;
using System.Collections.Generic;
using exercicio6.src;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa grupo = new Pessoa();
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa("João", 15));
            pessoas.Add(new Pessoa("Leandro", 21));
            pessoas.Add(new Pessoa("Paulo", 17));
            pessoas.Add(new Pessoa("Jessica", 18));

            Console.WriteLine();
            Console.WriteLine("-Lista Geral-");
            grupo.Apresentar(pessoas);
            grupo.excluirMenor(pessoas);
            Console.WriteLine();
            Console.WriteLine("-Maiores de 18 anos-");
            grupo.Apresentar(pessoas);
            Console.WriteLine();
            Console.WriteLine("Apresentar Jessica:");
            grupo.Procurar(pessoas);
            Console.ReadKey();
        }
    }
}
