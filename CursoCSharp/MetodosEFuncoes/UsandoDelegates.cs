using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class UsandoDelegates
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b)
        {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public static void Executar()
        {
            Soma ope1 = MinhaSoma;  // Função MinhaSoma() pode ser associada ao Tipo Soma pois possuem os mesmos parâmetros.
            Console.WriteLine(ope1(2, 3.9));

            ImprimirSoma ope2 = MeuImprimirSoma;
            ope2(5.4, 8);

            Func<double, double, double> ope3 = MinhaSoma;
            Console.WriteLine(ope3(2.5, 3));

            Action<double, double> ope4 = MeuImprimirSoma;
            ope4(7.7, 23.4);
        }
    }
}
