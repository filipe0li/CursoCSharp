using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    interface OperacaoBinaria   // Metodos de interface são abstract e bublic.
    {
        // Como Operacao é abstract não pode possuir corpo {..}.
        int Operacao(int a, int b);
    }
    interface Teste2 : OperacaoBinaria   // Uma interface pode herdar de outra interface, e quem herdar de uma, herdara da outra também.
    {
        bool Bla2(string a);
    }
    interface Teste
    {
        bool Bla(string a);
    }
    class Soma : OperacaoBinaria
    {
        // Não pode diminuir a visibilidade de um item de interface, obrigatório deixar public. É obrigatório implementar (terminar de construir) todos metódos.
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }
    class Subtracao : OperacaoBinaria, Teste    // Uma class pode herdar de multiplas interfaces.
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
        public bool Bla(string testes)
        {
            return true;
        }
    }
    class Multiplicacao : Teste2    // Multiplicacao herdou de Teste2 que traz junto OperacaoBinaria.
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
        public bool Bla2(string testes)
        {
            return true;
        }
    }
    class Calculadora
    {
        List<OperacaoBinaria> operadores = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperadores(int a, int b)
        {
            string resultado = "";

            foreach (var item in operadores)
            {
                resultado += $"Usando {item.GetType().Name} = {item.Operacao(a, b)}.\n";
            }
            return resultado;
        }
    }
    class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperadores(20, 5);
            Console.WriteLine(resultado);

        }
    }
}
