using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            string dirProjeto = @"~\source\repos\Teste\Teste\".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);    // DirectoryInfo precisa ser instanciado.

            if (dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("=========== Arquivos ===========");
            var arquivos = dirInfo.GetFiles();

            foreach (var item in arquivos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n=========== Diretóriios ===========");
            var pastas = dirInfo.GetDirectories();

            foreach (var item in pastas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dirInfo.CreationTime);    // Data de criação.
            Console.WriteLine(dirInfo.FullName);        // Caminho completo url.
            Console.WriteLine(dirInfo.Root);            // Drive.
            Console.WriteLine(dirInfo.Parent);          // Pasta anterior (pasta pai).
            Console.WriteLine(dirInfo.Parent.Parent);   // Pasta anterior/anterior (pasta pai do pai).
        }
    }
}
