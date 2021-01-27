using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct Dependente
    {
        public string Nome;
        public int Idade;
    }
    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3; // numero é um struct.
            int copiaNumero = numero;   // É feito cópia por valor, eles não compartilham a mesma memória.
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Beto", // Valores ORIGINAIS
                Idade = 20 // Valores ORIGINAIS
            };

            Dependente copiaDep = dep;  // Cada um tera um valor diferente, pois Dependente é uma struct.

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}\n{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Filipe";
            dep.Idade = 29;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}\n{dep.Idade} {copiaDep.Idade}");
        }
    }
}
