using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NAudio.Lame;
using NAudio.Wave;
using System.Media;

namespace YoutubeDownloader.ConvertirMp3
{
    internal class Convertir
    {
        public void ConvertToMp3(string inputfile, string outputfile)
        {
            try
            {
                using(AudioFileReader reader = new AudioFileReader(inputfile))
                {
                     using (LameMP3FileWriter writer = new LameMP3FileWriter(outputfile, reader.WaveFormat, LAMEPreset.VBR_50))
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
