using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    class ExemploTimeSpan
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine("Intervalo total: " + intervalo);

            // Somente mutos do intevalo:
            Console.WriteLine("Somente minutos: " + intervalo.Minutes);

            // total em minutos:
            Console.WriteLine("Intervalo total em minutos: " + intervalo.TotalMinutes.ToString("F"));   // Especificador de formato de ponto fixo ("F").

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);
            var tempo = chegada - largada;

            Console.WriteLine("Duração: " + tempo.ToString(@"hh\:mm\:ss"));                     // Formato personalizado => ToString(@"hh\:mm\:ss"), pois entre uma chamada e outra possui milisegundos entre o agora e a escrita na tela.

            Console.WriteLine("Adicionado 9 min: " + intervalo.Add(TimeSpan.FromMinutes(9)));   // Adiciona tempo ao intervalo de tempo, mas gera um novo TimeSpan, não atera de fato o original.

            Console.WriteLine("Removeu 9 min: " + intervalo.Add(TimeSpan.FromMinutes(-9)));     // Remove tempo ao intervalo de tempo, mas gera um novo TimeSpan, não atera de fato o original.

            Console.WriteLine("Intervalo atual: " + intervalo);                       // Original de fato não foi alterado.

            // ToString formato:
            Console.WriteLine("ToString g: " + intervalo.ToString("g"));
            Console.WriteLine("ToString G: " + intervalo.ToString("G"));
            Console.WriteLine("ToString c: " + intervalo.ToString("c"));

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds);        // Converte de string para TimeSpan, .TotalMilliseconds => só exibe o TimeSpan em milesegundos.
        }
    }
}
