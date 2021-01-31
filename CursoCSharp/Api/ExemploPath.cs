using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploPath
    {
        public static void Executar()
        {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo))  // Se arquivo não exista faça:
            {
                using (StreamWriter sw = File.CreateText(arquivo))  // Edita arquivo.
                {
                    sw.WriteLine("Um novo arquivo criado!");
                }
            }

            if (!Directory.Exists(pasta))   // Se pasta não existir faça:
            {
                Directory.CreateDirectory(pasta);   // Cria pasta.
            }

            Console.WriteLine(Path.GetExtension(arquivo));  // imprime extensão do arquivo.
            Console.WriteLine(Path.GetExtension(arquivo));  // imprime nome do arquivo.
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));  // imprime nome do arquivo com extennsão.
            Console.WriteLine(Path.GetDirectoryName(arquivo));  // imprime nome da pasta pai.
            Console.WriteLine(Path.HasExtension(arquivo));  // imprime true/false se arquivo possui exrtensão.

            Console.WriteLine(Path.HasExtension(pasta));  // imprime true/false se pasta possui exrtensão.
            Console.WriteLine(Path.GetFullPath(pasta));  // imprime caminho completo.
            Console.WriteLine(Path.GetPathRoot(pasta));  // imprime drive da pasta.

        }
    }
}
