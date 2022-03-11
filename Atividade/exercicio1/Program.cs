using System;
using exercicio1.src;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo("Chevrolet", "Celta", "ABC1020", "Branco", 25000);

            veiculo.Abastecer(100);
            veiculo.TanqueCombustivelAtual();
            veiculo.Ligar();
            veiculo.estadoAtual();
            veiculo.corAtual();
            veiculo.Pintar("Preto");
            veiculo.corAtual();
            veiculo.Frear();
            veiculo.Acelerar();
            veiculo.Desligar();
            veiculo.Frear();
            veiculo.Desligar();
            
          

            Console.ReadKey();
               
        }
    }
}
