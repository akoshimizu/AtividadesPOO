using System;

namespace exercicio2.src
{
    public class Livro : Produto
    {
        private string autor { get; set; }
        private string tema { get; set; }
        private int qtdPag { get; set; }

        public Livro()
        {

        }
        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag)
        {
            base.nome = nome;
            base.preco = preco;
            base.qtd = qtd;
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }


        public override string ToString()
        {
            string livro = "Titulo: " + nome + ", preco: " + preco.ToString("C") + " quantidade: " + qtd + " em estoque.";
            return livro;
        }

        public double calculaImposto()
        {
            
            if(tema == "educativo")
            {
                Console.WriteLine($"Livro educativo não tem imposto: {nome}.");
                return 0;
            }
            else
            {
                double imposto = preco * 0.10;
                Console.WriteLine($"{imposto.ToString("C")} de impostos sobre o livro {nome}.");
                return  imposto;
            }
        }

    }
}