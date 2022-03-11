using System;
using exercicio7.src;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente1 = new Gerente("Clecio", 40, 20000);
        
            Funcionario supervisor1 = new Supervisor("Ubiratam", 60, 10000);
            
            Funcionario vendedor1 = new Vendedor("Anderson", 30, 5000);

            gerente1.Apresentar();
            supervisor1.Apresentar();
            vendedor1.Apresentar();

            double bonusGerente = gerente1.Bonificação();
            double bonusSupervisor = supervisor1.Bonificação();
            double bonusVendedor = vendedor1.Bonificação();


            System.Console.WriteLine("Bonificação");
            gerente1.Apresentar(bonusGerente);
            supervisor1.Apresentar(bonusSupervisor);
            vendedor1.Apresentar(bonusVendedor);

            Console.ReadKey();
            
        }
    }
}
