using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)  // Funções (método) podem possuir o mesmo nome, mas não os mesmos prametros (atributos).
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Impossivel dividir por 0!");
                return 0;
            }
            return a / b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria = 0;

        public CalculadoraCadeia Somar(int a)   // O retorno é o proprio objeto, dando para chamar outras funções.
        {
            memoria += a;
            return this;   // O retorno é o proprio objeto.
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int resultado()
        {
            return memoria;
        }
    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            Console.WriteLine(calculadoraComum.Somar(5, 5));
            Console.WriteLine(calculadoraComum.Somar(5, 5));
            Console.WriteLine(calculadoraComum.Multiplicar(5, 5));
            Console.WriteLine(calculadoraComum.Dividir(5, 0));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            int resultado = calculadoraCadeia.Somar(3).Multiplicar(2).resultado();
            Console.WriteLine(resultado);
        }
    }
}
