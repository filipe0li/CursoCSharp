using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Data atual sem horas:
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Data atual com horas:
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);

            // Somente horas:
            Console.WriteLine("Hora: " + diaAtual.Hour);

            // Somente minutos:
            Console.WriteLine("Minutos: " + diaAtual.Minute);

            // Amanha:
            Console.WriteLine("Amanha: " + DateTime.Today.AddDays(1));

            // Ontem:
            Console.WriteLine("Ontem: " + DateTime.Today.AddDays(-1));

            // Convertendo datas para string:
            Console.WriteLine(diaAtual.ToString("dd")); // Somente dia.
            Console.WriteLine(diaAtual.ToString("d"));  // Dia mês e ano.
            Console.WriteLine(diaAtual.ToString("D"));  // Meuito descritivo, no tipo data sistema pt-BR no meu caso: dia da semana, dia , mês por extenso e ano.
            Console.WriteLine(diaAtual.ToString("g"));  // Dia, mês, ano, hora, minumto, AM/PM.
            Console.WriteLine(diaAtual.ToString("G"));  // Dia, mês, ano, hora, minumto, segundo, AM/PM.
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));  // Dia, mês, ano, hora, minumto, personalizavél.
        }
    }
}
