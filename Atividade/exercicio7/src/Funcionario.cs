using System;

namespace exercicio7.src
{
    public class Funcionario
    {
        protected string Nome { get; set; }
        protected int Idade { get; set; }
        protected double Salario { get; set; }


        public Funcionario(string nome, int idade, double salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
        }
        public virtual double Bonificação()
        {
            return Salario;
        }

        public virtual void Apresentar(double value)
        {
            //Console.WriteLine($"Cargo: ");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Salário: {Salario}");
            Console.WriteLine();
        }

        public void Apresentar()
        {
            //Console.WriteLine($"Cargo: ");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Salário: {Salario}");
            Console.WriteLine();
        }



    }
}