using System;
using System.Collections.Generic;
using exercicio4.src;

namespace exercicio4
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

            grupo.Apresentar(pessoas);
            Console.ReadKey();
        }
    }
}
