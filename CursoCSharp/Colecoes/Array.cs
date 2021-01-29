using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];    // Quando inicializar vazio array tem que colocar tamanho do array.
            alunos[0] = "Filipe";   //1
            alunos[1] = "Bia";      //2
            alunos[2] = "Carlos";   //3
            alunos[3] = "Emanuel";  //4
            alunos[4] = "Daniela";  //5

            foreach (string nome in alunos)
            {
                Console.WriteLine(nome);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            // Jeito fácil
            foreach (double nota in notas)
            {
                somatorio += nota;
            }

            // Jeito raiz
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            Console.WriteLine(new string(letras));  // new string converte array char em string
        }
    }
}
