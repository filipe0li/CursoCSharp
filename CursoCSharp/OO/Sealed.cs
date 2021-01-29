using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    sealed class SemFilho   // sealed => Class que não permite ser herdada.
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }

    //class SouFilho : SemFilho // Não da para herdar.
    //{

    //}

    class Avo
    {
        public virtual bool HonrarFamilia()
        {
            return true;
        }
    }
    class Pai : Avo
    {
        // Sobrescreve e sela HonrarFamilia().
        public sealed override bool HonrarFamilia()
        {
            return true;
        }
    }
    class FilhoRebelde : Pai
    {
        // FilhoRebelde não consegue sobrescrever HonrarFamilia(), pois ela é sealed.
        //public sealed override bool HonrarFamilia()
        //{
        //    return false;
        //}

        // Mas FilhoRebelde consegue instanciar(esconde a original) HonrarFamilia().
        //public new bool HonrarFamilia()
        //{
        //    return false;
        //}
    }

    class Sealed
    {
        public static void Executar()
        {
            // SemFilho não pode herdar par ninguém, mas continua podendo instanciar, pois é o mesmo namespace.
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde zeDroguinha = new FilhoRebelde();
            Console.WriteLine(zeDroguinha.HonrarFamilia());

        }
    }
}
