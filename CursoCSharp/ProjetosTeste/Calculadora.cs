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
            double valor1;
            double valor2;
            char operador = '0';
            Console.Clear();  // Limpa tela.

            Console.Write("Digite o primeiro valor: ");
        valor1:
            try
            {
                valor1 = double.Parse(Console.ReadLine()); // .Parse só converte de string.
            }
            catch (Exception)
            {
                Console.WriteLine("Apenas números!");
                goto valor1;
            }

            Console.Write("Escolha a opração ( + - x / ): ");
            try
            {
                operador = char.Parse(Console.ReadLine().ToLower());
            }
            catch (Exception)
            {
                Console.WriteLine("Operador possui apenas 1 caractere!");
            }
            
            Confere(operador);

            void Confere(char op)
            {
                char[] operadores = { '+', '-', 'x', '/' };
                if (!Array.Exists(operadores, element => element == op))
                {
                    Console.WriteLine("Digite um operador válido!");
                    operador = char.Parse(Console.ReadLine().ToLower());
                    Confere(operador);
                }
            }

            Console.Write("Digite o segundo valor: ");
        valor2:
            try
            {
                valor2 = double.Parse(Console.ReadLine()); // .Parse só converte de string.
            }
            catch (Exception)
            {
                Console.WriteLine("Apenas números!");
                goto valor2;
            }
            double resultado = 0;

            switch (operador)
            {
                default:
                    Console.WriteLine($"Erro, {operador} não é uma opção inválida!");
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
            string opcao = Console.ReadLine().ToLower();
            if (opcao == "s")
            {
                goto Inicio;
            }
        }
    }
}