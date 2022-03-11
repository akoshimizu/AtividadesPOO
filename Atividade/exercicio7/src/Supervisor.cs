using System;

namespace exercicio7.src
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override double Bonificação()
        {
            Salario += 5000; 
            return Salario;
        }

         public override void Apresentar(double value)
        {
            //Console.WriteLine($"Cargo: Supervisor");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Salário: {value}");
            Console.WriteLine();

        }


    }
}