using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader
{
    internal class Corregir
    {
        public string TituloCorregido(string titulo)
        {
            char[] caracteres = ['"', '<', '>', ':', '/', '|', '?', '*'];
            for (int i = 0; i < caracteres.Length; i++)
            {
                if (titulo.Contains(caracteres[i]))
                {
                    titulo = titulo.Replace(caracteres[i], ' ');
                }
            }
            return titulo;
        }
    }
}
