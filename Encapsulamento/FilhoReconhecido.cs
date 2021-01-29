using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoReconhecido tem acesso ...");
            Console.WriteLine(InfoPublica);     // public => Todos tem acesso.
            Console.WriteLine(CorDoOlho);       // protected => Herança.
            Console.WriteLine(NumeroCelular);   // internal => Dentro do mesmo namespace.
            Console.WriteLine(JeitoDeFalar);    // protected internal => Herança ou dentro do mesmo namespace.
            Console.WriteLine(SegredoDeFamilia);// private protected => Dentro da mesma class ou Herança dentro do mesmo namespace (C# >= 7.2).
                                                //Console.WriteLine(UsaMuitoPhotoshop); private => Padrão, acesso somente dentro da mesma class.
        }
    }
}
