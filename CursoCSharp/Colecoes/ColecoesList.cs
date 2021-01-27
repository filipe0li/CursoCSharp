using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto    // Se precionar ctrl + . aparece opção de gerar construtor,Equals(object obj), GetHashCode()
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)   // Construtor.
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) // Necessário para HashSet (pesquisa).
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() // Necessário para HashSet (pesquisa).
        {
            return HashCode.Combine(Nome, Preco);
        }
    }
    class ColecoesList  // É indexado e aceita repetições.
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>(); // Geeneric representa que o valor pode ser de qualquer tipo.
            carrinho.Add(livro);    // Add 1 item

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8º Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);   // ArrRange varios itens
            Console.WriteLine($"Carrinho possui {carrinho.Count} itens.");  // List cresce dinamicamente, ao contrario do Array.
            carrinho.RemoveAt(3);   // A partir do indice 0, remove o terçeiro, ou seja, ("Poster", 10)

            foreach (var item in carrinho)
            {
                Console.WriteLine($"\nNº: {carrinho.IndexOf(item)}, Nome: {item.Nome}, Preço = {item.Preco}");
            }

            carrinho.Add(livro);    // List aceita repetições
            Console.WriteLine($"\nCarrinho possui {carrinho.Count} itens.");
            foreach (var item in carrinho)
            {
                Console.WriteLine($"\nNº: {carrinho.IndexOf(item)}, Nome: {item.Nome}, Preço = {item.Preco}");
            }
        }
    }
}
