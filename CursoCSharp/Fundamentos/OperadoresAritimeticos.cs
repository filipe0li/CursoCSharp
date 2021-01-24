using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        static public void Executar()
        {
            // Preço com desconto

            var preço = 1000.0;
            var imposto = 335;
            var desconto = 0.1;

            double total = preço + imposto;

            var totalComDesconto = total - (total * desconto);  // Lembrando que não é necessário abrir colchetes pois a multiplicação tem preferencia sobre a soma.

            Console.WriteLine($"O preço final é: {totalComDesconto}");

            // IMC

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);   // Math.Pow(altura, 2) => (altura * altura)

            Console.WriteLine($"IMC é {imc}.");

            // Múmero Par/Impar

            int par = 24;
            int impar = 55;

            Console.WriteLine($"{par} / 2 tem resto {par % 2}");    // % => resto da divisão por 2
            Console.WriteLine($"{impar} / 2 tem resto {impar % 2}");
        }
    }
}
