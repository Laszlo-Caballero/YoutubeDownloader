using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeDownloader;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;


namespace YoutubeDownloader
{
    internal class Downloader
    {
        private YoutubeClient youtube = new YoutubeClient();

        public async Task DownloadVideo(string videoUrl, ProgressBar progreso)
        {
            var video = await youtube.Videos.GetAsync(videoUrl);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
            var streamInfo = streamManifest.GetVideoOnlyStreams().Where(s => s.Container == Container.Mp4).GetWithHighestVideoQuality();
            Console.WriteLine(streamInfo);
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
            var outputPath = Path.Combine(outputFolderAutor, $"{video.Title}.mp4");
            var progressHandler = new Progress<double>(progress =>
            {
                progreso.Value = (int)(progress * 100);
            });
            await youtube.Videos.Streams.DownloadAsync(streamInfo, outputPath, progressHandler);
        }
        public async Task DownloadAudio(string videoUrl, ProgressBar progreso )
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
            var outputPath = Path.Combine(outputFolderAutor, $"{video.Title}.{streamInfo.Container}");

            var progressHandler = new Progress<double>(progress =>
            {
                progreso.Value = (int)(progress * 100);
            });
            await youtube.Videos.Streams.DownloadAsync(streamInfo, outputPath, progressHandler);

            Console.WriteLine($"Video descargado en: {outputPath}");
        }
        public async Task DowloadPlaylist(string playlisturl, ProgressBar progreso)
        {
           await foreach(var videos in youtube.Playlists.GetVideosAsync(playlisturl))
            {
                await DownloadAudio(videos.Url, progreso);
            }
        }
    }
}
