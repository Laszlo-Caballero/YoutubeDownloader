using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeDownloader.ConvertirMp3;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;


namespace YoutubeDownloader.YoutubeDownloader
{
    internal class Downloader
    {
        private YoutubeClient youtube = new YoutubeClient();
        private Convertir convertir = new Convertir();
        private Corregir corregir = new Corregir();
        public async Task DownloadVideo(string videoUrl, ProgressBar progreso)
        {
            var video = await youtube.Videos.GetAsync(videoUrl);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
            var streamInfo = streamManifest.GetVideoOnlyStreams().Where(s => s.Container == Container.Mp4).GetWithHighestVideoQuality();
            var outputFolder = Path.Combine(Directory.GetCurrentDirectory(), "YoutubeDownloads");
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            var outputFolderAutor = Path.Combine(outputFolder, video.Author.ToString());
            if (!Directory.Exists(outputFolderAutor))
            {
                Directory.CreateDirectory(outputFolderAutor);
            }
            string title = corregir.TituloCorregido(video.Title);
            string outputVideo = Path.Combine(outputFolderAutor, $"{title}-NoAudio.mp4");

            var progressHandler = new Progress<double>(progress =>
            {
                progreso.Value = (int)(progress * 100);
            });
            await youtube.Videos.Streams.DownloadAsync(streamInfo, outputVideo, progressHandler);
        }
        public async Task DownloadAudio(string videoUrl, ProgressBar progreso)
        {
            var video = await youtube.Videos.GetAsync(videoUrl);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
            var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
            var outputFolder = Path.Combine(Directory.GetCurrentDirectory(), "YoutubeDownloads");
            var outputFolderAutor = Path.Combine(outputFolder, video.Author.ToString());
            if (!Directory.Exists(outputFolderAutor))
            {
                Directory.CreateDirectory(outputFolderAutor);
            }
            string title = corregir.TituloCorregido(video.Title);
            string outputPathDownload = Path.Combine(outputFolderAutor, $"{title}.{streamInfo.Container}");
            string outputPath = Path.Combine(outputFolderAutor, $"{title}.mp3");

            var progressHandler = new Progress<double>(progress =>
            {
                progreso.Value = (int)(progress * 100);
            });
            await youtube.Videos.Streams.DownloadAsync(streamInfo, outputPathDownload, progressHandler);
            convertir.ConvertToMp3(outputPathDownload, outputPath);
            File.Delete(outputPathDownload);
        }
        public async Task DowloadPlaylist(string playlisturl, ProgressBar progreso)
        {
            await foreach (var videos in youtube.Playlists.GetVideosAsync(playlisturl))
            {
                await DownloadAudio(videos.Url, progreso);
            }
        }
    }
}
