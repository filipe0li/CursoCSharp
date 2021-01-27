using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca; // Se não colocar nada já é privado!
        private string Modelo;
        private uint Cilindrada;    // uint não aceita valores negativos.

        public Moto(string marca, string modelo, uint cilindrada)    // Construtor "possui o mesmo nome da class"
        {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);

        }

        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            //if (cilindrada > 0)
            //{
            Cilindrada = cilindrada;
            //}
            //Cilindrada = Math.Abs(cilindrada);    // Converte para inteiro positivo.
        }
    }
    class GetSet    //  Serve para proteção (tratamento) de valores, evitar valores errados;
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-GR", 636);   // Construtor com parametros.

            Console.WriteLine($"{moto1.GetMarca()}\n{moto1.GetModelo()}\n{moto1.GetCilindrada()}");

            var moto2 = new Moto();   // Construtor sem parametros.
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);

            Console.WriteLine($"{moto2.GetMarca()}\n{moto2.GetModelo()}\n{moto2.GetCilindrada()}");
        }
    }
}
