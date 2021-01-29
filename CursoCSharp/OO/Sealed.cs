using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    sealed class SemFilho   // sealed => Class que n�o permite ser herdada.
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }

    //class SouFilho : SemFilho // N�o da para herdar.
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
        // FilhoRebelde n�o consegue sobrescrever HonrarFamilia(), pois ela � sealed.
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
            // SemFilho n�o pode herdar par ningu�m, mas continua podendo instanciar, pois � o mesmo namespace.
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde zeDroguinha = new FilhoRebelde();
            Console.WriteLine(zeDroguinha.HonrarFamilia());

        }
    }
}
