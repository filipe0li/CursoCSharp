using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        public static void Recepcionar(params string[] pessoas) // params string[] pessoas, cada parametro que é passado é colocado entro da string "pessoas".
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Olá {pessoa}");
            }
        }
        public static void Executar()
        {
            Recepcionar("Filipe", "Thamara", "Sandra", "José", "Jorge");
        }
    }
}
