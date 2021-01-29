using System;
using System.Collections; // Stack();
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecaoStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push("a");  // Push => Adiciona itens a Pilha(Stack).
            pilha.Push(3);
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n\nPop: {0}\n", pilha.Pop()); // .Pop() => Remove o Primeiro  elemento da lista no caso (3.14f), q foi o último a ser adicionado, efeito pilha.

            foreach (var item in pilha) // Pilha esta sem elemento 3.14f
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("\nPeek: {0}", pilha.Peek()); // .Peek => Exibe primeiro elemento da fila, no caso (true)
        }
    }
}
