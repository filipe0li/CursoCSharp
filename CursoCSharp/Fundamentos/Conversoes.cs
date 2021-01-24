using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;  // Nesta conversão de int para double, não há perca de informação, pois o double tem maior capacidade.
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota;  /*  Casting => Nesta conversão de double para int, há perca de informação, pois o double tem maior capacidade que o int.
                                             *  Então é necessário especificar colocando (int), para forçar a converção. */
            Console.WriteLine($"Nota truncada: {notaTruncada}");

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);  // Converte de String para int.
            Console.WriteLine($"Idade inserida: {idadeInteiro}");
            Console.WriteLine(idadeInteiro.GetType());

            idadeInteiro = Convert.ToInt32(idadeString);  // Converte de String para int.
            Console.WriteLine($"Resultado {idadeInteiro}");
            Console.WriteLine(idadeInteiro.GetType());

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);  // TryParse=> tenta converter para número sem gerar erro caso usuário escreva string.
            Console.WriteLine($"Resultado: {numero}");

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);  // int numero2 foi criada dentro da função.
            Console.WriteLine($"Resultado: {numero2}");
        }
    }
}
