using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            bool executouTrabalho1 = false;
            bool executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;  // && E, só da true se todos forem true, se tiver 1 false, da false
            Console.WriteLine($"Comprou a Tv de 50º? {comprouTv50}");

            bool comprouSorvete = executouTrabalho1 || executouTrabalho2;   // || OU, só da flase se tiver todos false, aceita qualquer true.
            Console.WriteLine($"Comprou sorvete? {comprouSorvete}");

            bool comprouTv32 = executouTrabalho1 ^ executouTrabalho2;   // ^ OU EXCLUSIVO, da true somente quando possui 1 true e 1 false.
            Console.WriteLine($"Comprou a Tv de 32º? {comprouTv32}");

            Console.WriteLine($"mais saudável? {!comprouSorvete}"); // ! NEGAÇÃO, inverte valor, se true=> false, se false => true.
        }
    }
}
