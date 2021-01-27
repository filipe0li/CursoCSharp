using System;
using System.Collections; // Para uso do ArrayList
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            var arraylist = new ArrayList   // Aceita tipos diversos jutos, na mesma list.
            {
                "Palavra", 3, true
            };

            arraylist.Add(3.14);

            foreach (var item in arraylist)
            {
                Console.WriteLine($"{item} do tipo => {item.GetType()}");
            }
        }
    }
}
