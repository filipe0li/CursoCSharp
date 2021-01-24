using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveiisEConstantes
    {
        public static void Executar()
        {
            // Área da circunferencia
            double raio = 4.5;  // double é do tipo valor real que aceita casas decimais (não aceita strin nem boolean).

            const double PI = 3.14;     // const não pode ter seu valor alterado.

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Exemplo de soma com parênteses " + /* É necessário abrir parênteses para que a soma seja feita antes*/ (area + 1000));
            Console.WriteLine("Exemplo de soma sem parênteses " + area + 1000);

            // Tipos internos

            bool estaChovendo = false;  // bool determina tipo boolean (true / false).
            Console.WriteLine("Está choventdo " + estaChovendo);

            byte idade = 45;    // Tipo byte 8-bit unsigned integer 0 to 255.
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // Tipo sbyte 8-bit signed integer -128 to 127 // .MinValue (menor valor de [sbyte], no caso -128).
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue; // Tipo short 16-bit signed integer -32,768 to 32,767 // .MaxValue (maior valor de [short], no caso 32,767).
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Tipo int 32-bit signed integer -2,147,483,648 to 2,147,483,647.
            Console.WriteLine("Menor valor Int " + menorValorInt);

            uint populacaBrasileira = 207_600_000;  // Tipio uint 32-bit unsigned integer 0 to 4,294,967,295.
            Console.WriteLine("população Brasileira " + populacaBrasileira);

            long menorValorLong = long.MinValue;    // Tipo long 64-bit signed integer -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; // Tipo ulong 64-bit unsigned integer 0 to 18,446,744,073,709,551,615.
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99F;   // Tipo float 32-bit Single-precision floating point type -3.402823e38 to 3.402823e38. // O f sufixo simplesmente diz ao compilador qual é a float qual é a double.
            Console.WriteLine("Preço do Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;    // Tipo double 64-bit double-precision floating point type -1.79769313486232e308 to 1.79769313486232e308. // É o mais usado.
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrela = decimal.MaxValue;   // Tipoi decimal 128-bit decimal type for financial and monetary calculations (+ or -)1.0 x 10e-28 to 7.9 x 10e28.
            Console.WriteLine("Distância entre as Estrelas " + distanciaEntreEstrela);

            char letra = 'b';   // Tipo char 16-bit SINGLE Unicode character Any valid character, e.g. a,*, \x0058 (hex), or\u0058 (Unicode).
            Console.WriteLine("Letra " + letra);    // Detalhe '' aspas simples só servem pra encapsular uma letra.

            string texto = "Seja bem vindo ao Curso de C#!"; // string A SEQUENCE of Unicode characters.
            Console.WriteLine(texto);
        }
    }
}
