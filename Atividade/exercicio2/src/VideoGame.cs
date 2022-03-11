using System;

namespace exercicio2.src
{
    public class VideoGame : Produto , IImposto
    {
        private string marca { get; set; }
        private string modelo { get; set; }
        private bool inUsado { get; set; }


        public VideoGame()
        {
            
        }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool inUsado)
        {
            base.nome = nome;
            base.preco = preco;
            base.qtd = qtd;
            this.marca = marca;
            this.modelo = modelo;
            this.inUsado = inUsado;
        }
        public override string ToString()
        {
            string game = "Video-game: " + nome + ", preco: " + preco.ToString("C") + " quantidade: " + qtd + " em estoque.";
            return game;
        }
        
        public double calculaImposto()
        {
            double imposto;
            if(inUsado == true)
            {
                imposto = preco * 0.25;
                Console.WriteLine($"Imposto {nome} {modelo} usado, {imposto.ToString("C")}.");
                return imposto;
            }
            else
            {
                imposto = preco * 0.45;
                System.Console.WriteLine($"Imposto {nome} {modelo} {imposto.ToString("C")}.");
                return  imposto;
            }
        }
    }
}