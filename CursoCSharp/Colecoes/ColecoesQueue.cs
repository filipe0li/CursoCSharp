using System;
using System.Collections.Generic;   // Para => var fila = new Queue<string>();
using System.Collections;   // Para => var salada = new Queue();

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>(); // Queue<string>() => Só aceita tipo string
            fila.Enqueue("Fulano");
            fila.Enqueue("Cicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");   // Queue aceita repetições.

            Console.WriteLine(fila.Peek());    // .Peek() => Exibe 1º elemento da fila.
            Console.WriteLine(fila.Count);  // .Count => Exibe quantidade de itens na Queue.


            Console.WriteLine(fila.Dequeue());  // Remove 1º elemento da fila (no caso Fulano).
            Console.WriteLine(fila.Count);

            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }


            var salada = new Queue();   // new Queue() => Aceita todos tipos juntos.
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Item")); // .Contains() => Retorna bool e perquisa se possui item.

            foreach (var item in salada)
            {
                Console.WriteLine(item);
            }
        }
    }
}
