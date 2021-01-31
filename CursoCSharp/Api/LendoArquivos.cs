using System;
using System.IO;

namespace CursoCSharp.Api
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path)) // Se arquivo path não existir, faça:
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Pruduto;Preco;Qtde");
                    sw.WriteLine("Caneta BIC;3.59;89");
                    sw.WriteLine("Borracha Branca;2.89;27");
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd(); // Arquivo até o final.
                    Console.WriteLine(texto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  // Imprime erro!
            }
        }
    }
}
