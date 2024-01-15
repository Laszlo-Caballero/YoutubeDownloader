using YoutubeDownloader.ModalDownload;

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
            if (txtLink.Text.Contains("www.youtube.com/watch") || txtLink.Text.Contains("www.youtube.com/playlist"))
            {
                btnDownload.Enabled = true;
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            string link = txtLink.Text;
            txtLink.Text = "";
            Modal modal = new Modal(opciones.Text, link, this);
            
            modal.Show();
        }
    }
}
