using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ProjetosTeste
{
    class Calculadora
    {
        public static void Executar()
        {
        Inicio: // Marcador.
            Console.Clear();  // Limpa tela.
            Console.Write("Digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine()); // .Parse só converte de string.

            Console.Write("Escolha a opração ( + - x / ): ");
            char operador = char.Parse(Console.ReadLine().ToLower());
            Confere(operador);

            void Confere(char operador)
            {
                char[] operadores = { '+', '-', 'x', '/' };
                if (!Array.Exists(operadores, element => element == operador))
                {
                    Console.WriteLine("Digite um operador válido!");
                    operador = char.Parse(Console.ReadLine().ToLower());
                    Confere(operador);
                }
            }

            Console.Write("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (operador)
            {
                default:
                    Console.WriteLine("Erro, opção inválida!");
                    break;
                case '+':
                    resultado = valor1 + valor2;
                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;
                case '-':
                    resultado = valor1 - valor2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;
                case 'x':
                    resultado = valor1 * valor2;
                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;
                case '/':
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                        Console.WriteLine("O resultado da divisão é: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Impossivel dividir por 0");
                    }
                    break;

            }
            Console.Write("Deseja continuar calculando ( S / N )? ");
            char opcao = char.Parse(Console.ReadLine().ToLower());
            if (opcao == 's')
            {
                goto Inicio;
            }
        }
    }
}