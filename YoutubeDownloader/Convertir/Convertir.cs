using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Lame;
using NAudio.Wave;

namespace YoutubeDownloader.ffmpeg
{
    internal class Convertir
    {
        public void ConvertToMp3(string inputfile, string outputfile)
        {
            try
            {
                using(var reader = new AudioFileReader(inputfile))
                {
                     using (var writer = new LameMP3FileWriter(outputfile, reader.WaveFormat, LAMEPreset.VBR_50))
                    {
                        reader.CopyTo(writer);
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
