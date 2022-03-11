using System;

namespace exercicio1.src
{
    public class Veiculo
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private string Placa { get; set; }
        private string Cor { get; set; }
        private float Km { get; set; }
        private bool isLigado { get; set; }
        private int litrosCombustivel { get; set; }
        private int Velocidade { get; set; }
        private double Preco { get; set; }



        public Veiculo (string Marca, string Modelo, string Placa, string Cor, double Preco)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Placa = Placa;
            this.Cor = Cor;
            this.Preco = Preco;            
        }

        public Veiculo()
        {
        }

        public void Acelerar()
        {
            Velocidade += 20;
            if (Velocidade>60)
            {
                Console.WriteLine("Velocidade não pode exceder a 60Km/h");
                Velocidade -= 20;
            }
            else
            {
                Console.WriteLine($"Velocidade atual: {Velocidade}");
            }
        }

        public void Abastecer(int combustivel)
        {
            litrosCombustivel += combustivel;
            if (litrosCombustivel>60)
            {
                int excessoCombustivel = litrosCombustivel - 60;
                litrosCombustivel -= excessoCombustivel;
            }
        }

        public void Frear()
        {
            
            if (Velocidade==0)
            {
                Console.WriteLine("Veículo parado");
            }
            else
            {
                Velocidade -= 20;
                Console.WriteLine($"Velocidade atual: {Velocidade}");
            }
        }

        public void Pintar(string cor)
        {
            this.Cor = cor;
        }

        public void Ligar()
        {
            if (!isLigado)
            {
                isLigado = true;
                Console.WriteLine("Carro Ligado!");
            }
            else
            {
                Console.WriteLine("Carro já está ligado!");
            }
        }

        public void Desligar()
        {
            if (isLigado && Velocidade ==0)
            {
                isLigado = true;
                Console.WriteLine("Carro Desligado.");
            }
            else
            {
                Console.WriteLine("Veículo em movimento. Necessário pará-lo para poder desligar seu carro.");
            }
        }


        public void TanqueCombustivelAtual()
        {
            Console.WriteLine($"Tanque combustívelvel atual: {litrosCombustivel}");
        }

        public void estadoAtual()
        {
            Console.WriteLine($"Estado atual do carro: {isLigado}");
        }

        public void corAtual()
        {
            Console.WriteLine($"Cor: {this.Cor}");
        }


    }
}