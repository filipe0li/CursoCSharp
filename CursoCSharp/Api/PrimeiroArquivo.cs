using System;
using System.IO;    // Import

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            // Encontra pasta do usúario:
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || // É um Linux?
            Environment.OSVersion.Platform == PlatformID.MacOSX)    // ou é im Mac?
            ? Environment.GetEnvironmentVariable("HOME")    // Se for Linux ou Mac use este:
            : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%"); // Se for Windows use este:
            return path.Replace("~", home); // substitui.
        }
    }
    class PrimeiroArquivo
    {
        public static void Executar()
        {
            //var s = @"\teste\nestes\a.txt"; // @ é necessário para não interpretar \n e \t.
            //Console.WriteLine(s);
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) // Arquivo existe?
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    // escreve no arquivo
                    sw.WriteLine("Esse é\no nosso\nprimeiro\narquivo.");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("É possivel\nadicionar\nmais texto!");
            }
        }
    }
}
