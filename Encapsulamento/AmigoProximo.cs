using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class AmigoProximo // Não recebe Heraça.
    {
        // Como não ha Herança de SubCelebridade é necessário instanciar (referênciar) SubCelebridade.
        public readonly SubCelebridade amigo = new SubCelebridade();
        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo tem acesso ...");
            Console.WriteLine(amigo.InfoPublica);           // public => Todos tem acesso.
            //Console.WriteLine(amigo.CorDoOlho);           // protected => Herança.
            Console.WriteLine(amigo.NumeroCelular);         // internal => Dentro do mesmo namespace.
            Console.WriteLine(amigo.JeitoDeFalar);          // protected internal => Herança ou dentro do mesmo namespace.
            //Console.WriteLine(amigo.SegredoDeFamilia);    // private protected => Dentro da mesma class ou Herança dentro do mesmo namespace (C# >= 7.2).
            //Console.WriteLine(amigo.UsaMuitoPhotoshop);   // private => Padrão, acesso somente dentro da mesma class.
        }
    }
}
