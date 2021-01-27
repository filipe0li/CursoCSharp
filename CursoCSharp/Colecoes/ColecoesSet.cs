using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet   // Set não é indexado (não da numeroa aos itens) e não aceita repetições.
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>(); // Geeneric representa que o valor pode ser de qualquer tipo.
            carrinho.Add(livro);    // Add 1 item

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8º Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)   // Não será adicionado.  Precisou gerar GetHashCode() e Equals(object obj).
            };

            carrinho.UnionWith(combo);   // UnionWith adiciona varios itens
            Console.WriteLine($"Carrinho possui {carrinho.Count} itens.");  // List cresce dinamicamente, ao contrario do Array.

            foreach (var item in carrinho)
            {
                Console.WriteLine($"\nNome: {item.Nome}, Preço = {item.Preco}");
            }

            carrinho.Add(livro);    // HashSet não aceita repetições, ele sobrescreve o que já tem.
            Console.WriteLine($"\nCarrinho possui {carrinho.Count} itens.");
            foreach (var item in carrinho)
            {
                Console.WriteLine($"\nNome: {item.Nome}, Preço = {item.Preco}");
            }
        }
    }
}
