using System;
using System.Collections.Generic;

namespace exercicio2.src
{
    public class Loja
    {
        private string nome { get; set; }
        private string cnpj { get; set; }
        private List<Livro> livros { get; set; }
        private List<VideoGame> videoGames { get; set; }


        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.livros = livros;
            this.videoGames = videoGames;
        }

        public void listarLivros()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"A Loja {nome} possui estes livros para venda:");
            foreach (var item in livros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");
        }

        public void listarLVideoGame()
        {
            foreach (var item in videoGames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");
        }

        public double calculaPatrimonio()
        {
            double totalVideoGames = 0;
            double totalLivros = 0;
            double patrimonioTotal = 0;

            foreach (var item in videoGames)
            {
                totalVideoGames += item.GetPreco() * item.GetQtd();
            }
            
            foreach (var item in livros)
            {
                totalVideoGames += item.GetPreco() * item.GetQtd();
            }

            patrimonioTotal = totalLivros + totalVideoGames;

            Console.WriteLine($"O patrimonio da loja: {nome} é de {patrimonioTotal.ToString("C")}");
            return patrimonioTotal;
        }
    }    
}