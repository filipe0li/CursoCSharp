using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Filipe";    // Se não for especificado tipo C# estipula automaticamente baseado no que esta escrito (no caso "" determiniu string). Mas continua sendo tipada.
            //nome = 123;   // Não é possivel alterar pois foi definido automáticamente para string.
            Console.WriteLine(nome);

            var idade = 29;  // Se não for especificado tipo C# estipula automaticamente baseado no que esta escrito (no caso 29 determiniu double). Mas continua sendo tipada.
            Console.WriteLine(idade);

            int a;  // Só declarei.
            a = 3;  // Atribui valor. Não precisa inserir tipo novamente.

            int b = 2;  // Declarado e atribuido.

            Console.WriteLine(a + b);
        }
    }
}
