using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;

            Console.Write("Digite a nota do aluno: ");
            float.TryParse(Console.ReadLine(), out float nota);

            Console.Write("Aluno possui bom comportamento? (S/N): ");
            string entradaConsole = Console.ReadLine().ToLower();

            bomComportamento = entradaConsole == "s";  // Versão simplificada de ==> if (entradaConsole == "s") {bomComportamento = true;};

            if (nota >= 9.0 && bomComportamento)    // bomComportamento já é booleano não precisa fazer ==> (nota >= 9.0 && bomComportamento = true)
            {
                Console.WriteLine("Aluno vai para o Quadro de Honra!");
            }
        }
    }
}
