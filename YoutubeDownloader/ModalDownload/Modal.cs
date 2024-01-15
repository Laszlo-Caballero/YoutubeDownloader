using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDownloader.ModalDownload
{
    public partial class Modal : Form
    {
        private string opcion;
        private string url;
        private Form elegir;
        private Downloader download = new Downloader();
        public Modal(string vopcion, string vurl, Form velegir)
        {
            InitializeComponent();
            opcion = vopcion;
            url = vurl;
            elegir = velegir;
        }

        private async void Modal_Load(object sender, EventArgs e)
        {
            elegir.Enabled = false;
            switch (opcion)
            {
                case "Audio":
                    await download.DownloadAudio(url, progreso);
                    btnClose.Enabled = true;
                    txtDownload.Visible = true;
                    break;
                case "Video":
                    await download.DownloadVideo(url, progreso);
                    btnClose.Enabled = true;
                    txtDownload.Visible= true;
                    break;
                case "Playlist":
                    await download.DowloadPlaylist(url, progreso);
                    btnClose.Enabled = true;
                    txtDownload.Visible = true;
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            elegir.Enabled = true;
            this.Close();
        }
    }
}
