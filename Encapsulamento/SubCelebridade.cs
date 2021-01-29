using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade // public class => Para que haja Herança por importação.
    {
        // public => Todos tem acesso.
        public string InfoPublica = "Tenho um instagram!";

        // protected => Herança.
        protected string CorDoOlho = "Verde";

        // internal => Dentro do mesmo namespace.
        internal ulong NumeroCelular = 5551997059232;

        // protected internal => Herança ou dentro do mesmo namespace.
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // private protected => Dentro da mesma class ou Herança dentro do mesmo namespace (C# >= 7.2).
        private protected string SegredoDeFamilia = "Bla bla bla";

        // private => Padrão, acesso somente dentro da mesma class.
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade tem acesso ...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
