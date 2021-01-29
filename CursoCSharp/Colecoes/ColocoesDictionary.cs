using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColocoesDictionary  // Aceita repetição na string as não no numero int.
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();
            filmes.Add(2000, "Gladiador");  // Add => Adiciano elemento ao Dictionary.
            filmes.Add(2002, "Homen-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) // Faz pesquisa.
            {
                Console.WriteLine("2004: {0}\n", filmes[2004]); // Como o int não pode ser alterado ele serve como um indice, para localizar o item.
                                                                //  TESTAR ERRO!!!!!!!!!!!!!!!!!!!!!!
                                                                //Console.WriteLine("2004: {0}", filmes.GetValueOrDefalt(2008)) // Se possuir valor associado retornara o valor. Se não possuir valor associado ao valor, retornará um string vazia por padrão.
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia") + "\n"); // retorna bool.

            Console.WriteLine("Removeu? {0}\n", filmes.Remove(2004)); // retorna bool. Se existir e se ele conseguir remover retorna true.

            filmes.TryGetValue(2006, out string filme2006); // Cria uma cópia não associada a memória e imprime na string filme2006.
            Console.WriteLine("Filme: {0}\n", filme2006); // Se possuir valor associado retornara o valor. Se não possuir valor associado ao valor, retornará um string vazia por padrão.

            //  Formas de percorrer os valores  //
            foreach (int item in filmes.Keys) // Somente Números.
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine("\n");

            foreach (string item in filmes.Values) // Somente strings.
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine("\n");

            foreach (KeyValuePair<int, string> item in filmes)  // KeyValuePair<int, string> => 2 valores.
            {
                Console.WriteLine("{0} é do ano {1}", item.Value, item.Key);
            }
            Console.WriteLine("");
            foreach (var item in filmes)  // Exibe os 2 valores do jeito mais fácil.
            {
                Console.WriteLine("{0} é do ano {1}", item.Value, item.Key);
            }
        }
    }
}
