using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto    // Constutor com parâmetros.
    {
        public string Nome;
        public float Preco;
        public static float Desconto = 0.2f;    // variavel Desconto é static, não pode haver atribuição a ela.

        public Produto(string nome, float preco/*, float desconto*/)
        {
            Nome = nome;
            Preco = preco;
            //Desconto = desconto;
        }

        public Produto()    // Construtor padrão, sem parâmetros (ele usa as variaveis que estão na class Produto).
        {

        }

        public float CalcuularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }
    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("caneta", 3.2f/*, 0.1f*/);   // Este usa o construtor com parâmetros.

            var produto2 = new Produto()
            {
                Nome = "Borracha",  // virgula para diferenciar os atributos.
                Preco = 5.3f,
                //Desconto = 0.5f,
            };  // Ponto e virgula necessário.

            Produto.Desconto = 0.05f;   // variavel Desconto é static, não pode haver atribuição a ela. Deve ser chamada pela class.
            Console.WriteLine($"Preço com desconto: {produto1.CalcuularDesconto()}");
            Console.WriteLine($"Preço com desconto: {produto2.CalcuularDesconto()}");

            Produto.Desconto = 0.5f;
            Console.WriteLine($"Preço com desconto: {produto1.CalcuularDesconto()}");
            Console.WriteLine($"Preço com desconto: {produto2.CalcuularDesconto()}");

        }
    }
}
