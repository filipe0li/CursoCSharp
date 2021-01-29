using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public abstract class Celular   // abstract => Necess�rio para ter m�todo abstract.
    {
        public abstract string Assistente();    // M�todo(Fun��o) Abstrata => Sem corpo(quem herdar ter� que implementar o corpo), toda class que herdar de Celular ter� o m�todo Assistente().

        public string Tocar()
        {
            return "Trim ttrim trim...";
        }
    }
    public class Sansung : Celular
    {
        // override => Necess�rio pois a fun��o Assistente est� inacabada.
        public override string Assistente()
    {
            return "Ol�! Meu nome � Bixby!";
    }
    }
    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Ol�! Meu nome � Siri!";
        }
    }
class Abstract
    {

        public static void Executar()
        {
            //Celular c = new Celurar();    // abstract => N�o deixa instanciar.
            var Celulares = new List<Celular>
                {
                    new Iphone(),
                    new Sansung()
                };

            foreach (var celular in Celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
