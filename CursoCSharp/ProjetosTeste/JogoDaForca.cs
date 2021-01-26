using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ProjetosTeste
{
    class JogoDaForca
    {
        public static void Executar()
        {
        Inicio: // Marcador.
            Console.Clear();  // Limpa tela.
            Console.Write("Digite a palavra secreta: ");
            string palavraChave = Console.ReadLine().ToLower();
            Console.Clear();  // Limpa tela.

            char[] secreta = new char[palavraChave.Length];  // Cria arrey que contem palavra secreta (maior palavra do alfabeto brasileiro possui 46 letras).
            int numeroDeLetrasSecretas = 0;
            byte i = 0;
            foreach (char letra in palavraChave)
            {
                if (letra != ' ')
                {
                    secreta[i] = '-';
                    numeroDeLetrasSecretas++;
                }
                else
                {
                    secreta[i] = ' ';
                }
                i++;
            }

            int numeroDeChances = numeroDeLetrasSecretas + 2;  // Regra para número de chances.
            char[] letrasDigitadas = new char[numeroDeChances + numeroDeLetrasSecretas];  // Alfabeto possui 26 letras.
            byte numeroDeTentativa = 0;

            Console.WriteLine(secreta); //  Imprime secreta em forma de '-'
            Console.WriteLine($"\nA palavra secreta possui {numeroDeLetrasSecretas} letras.\nVocê possui {numeroDeChances} chances!"); // Dicas

            while (numeroDeChances > 0 && Array.Exists(secreta, element => element == '-')) // Regra número de chances > 0 e não ter acertado a palavraChave
            {
                bool acerto = false;

                Console.Write("Digite um letra: ");
                char letraDigitada = char.Parse(Console.ReadLine());

                Console.Clear();  // Limpa tela.

                if (Array.Exists(letrasDigitadas, element => element == letraDigitada))
                {
                    Console.WriteLine("Você já digitou está letra! Acabou de perder uma jogada!");
                    numeroDeChances--;
                }
                else
                {
                    letrasDigitadas[numeroDeTentativa] = letraDigitada;
                }

                numeroDeTentativa++;

                i = 0;
                foreach (char letra in palavraChave)
                {
                    if (letraDigitada == letra)
                    {
                        secreta[i] = letraDigitada;
                        acerto = true;
                    }
                    i++;
                }

                Console.WriteLine(secreta); // Imprime palavra atualizada.

                if (!acerto)
                {
                    numeroDeChances--;
                }
                if (numeroDeChances > 0)
                {
                    Console.Write("Letras digitadas: ");
                    Console.WriteLine(letrasDigitadas);
                    Console.WriteLine($"\nA palavra secreta possui {numeroDeLetrasSecretas} letras.\nVocê possui {numeroDeChances} chances!");
                }
            }

            Console.Clear();  // Limpa tela.
            if (!Array.Exists(secreta, element => element == '-'))
            {
                Console.WriteLine($"Parabéns você acertou a palavra secreta em {numeroDeTentativa} tentativas!\nA palavra secreta era {palavraChave}");
            }
            else
            {
                Console.WriteLine($"Que pena você Perdeu!\nA palavra secreta era {palavraChave}");
            }

            Console.Write("GameOver!\nDeseja continuar jogando ( S / N )? ");
            char opcao = char.Parse(Console.ReadLine().ToLower());
            if (opcao == 's')
            {
                goto Inicio;
            }
        }
    }
}