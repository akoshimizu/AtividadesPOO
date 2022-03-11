using System;

namespace exercicio7.src
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override double Bonificação()
        {
            Salario += 10000; 
            return Salario;
        }

         public override void Apresentar(double value)
        {
            //Console.WriteLine($"Cargo: Gerente");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Salário: {value}");
            Console.WriteLine();

        }
        
    }
}