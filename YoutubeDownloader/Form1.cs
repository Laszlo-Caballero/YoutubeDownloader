namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        private Downloader descargar = new Downloader();
        public Form1()
        {
            InitializeComponent();
            opciones.SelectedIndex = 0;
        }

        private void txtLink_TextChanged(object sender, EventArgs e)
        {
            if (txtLink.Text.Contains("www.youtube.com/watch"))
            {
                btnDownload.Enabled = true;
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            string tipo = opciones.Text;
            string url = txtLink.Text;
            switch (tipo)
            {
                case "Audio":
                  await  descargar.DownloadAudio(url);
                    MessageBox.Show("Descarga finalizada");
                break;
                case "Video":
                    await descargar.DownloadVideo(url);
                    MessageBox.Show("Descarga finalizada");
                    break;
                case "Playlist":
                    await descargar.DowloadPlaylist(url);
                    MessageBox.Show("Descarga finalizada");
                    break;
            }
        }
    }
}
