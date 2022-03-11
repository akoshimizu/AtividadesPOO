using System;

namespace exercicio7.src
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override double Bonificação()
        {
            Salario += 3000; 
            return Salario;
        }

         public override void Apresentar(double value)
        {
            //Console.WriteLine($"Cargo: Venderdor");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Salário: {value}");
            Console.WriteLine();

        }
    }
}