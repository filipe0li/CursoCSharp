using System;
using System.Collections.Generic;
using Encapsulamento; // Importa namepace Encapsulamento.

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade // Herança por importação (fora do namespace).
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido tem acesso ...");
            Console.WriteLine(InfoPublica);         // public => Todos tem acesso.
            Console.WriteLine(CorDoOlho);           // protected => Herança.
            //Console.WriteLine(NumeroCelular);     // internal => Dentro do mesmo namespace.
            Console.WriteLine(JeitoDeFalar);        // protected internal => Herança ou dentro do mesmo namespace.
            //Console.WriteLine(SegredoDeFamilia);  // private protected => Dentro da mesma class ou Herança dentro do mesmo namespace (C# >= 7.2).
            //Console.WriteLine(UsaMuitoPhotoshop); // private => Padrão, acesso somente dentro da mesma class.
        }
    }
    public class AmigaDistante
    {
        // Como não ha Herança de SubCelebridade é necessário instanciar (referênciar) SubCelebridade.
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigaDistante tem acesso ...");
            Console.WriteLine(amiga.InfoPublica);         // public => Todos tem acesso.
            //Console.WriteLine(amiga.CorDoOlho);         // protected => Herança.
            //Console.WriteLine(amiga.NumeroCelular);     // internal => Dentro do mesmo namespace.
            //Console.WriteLine(amiga.JeitoDeFalar);      // protected internal => Herança ou dentro do mesmo namespace.
            //Console.WriteLine(amiga.SegredoDeFamilia);  // private protected => Dentro da mesma class ou Herança dentro do mesmo namespace (C# >= 7.2).
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); //private => Padrão, acesso somente dentro da mesma class.
        }
    }
    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();
            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigaDistante().MeusAcessos();
        }
    }
}
