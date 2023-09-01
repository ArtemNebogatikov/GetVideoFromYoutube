using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace GetVideoFromYoutube
{
    class DownloadVideo : Command
    {
        private string url;
        public DownloadVideo(string url)
        {
            this.url = url;
        }

        public override async void Run()
        {        
            var youtubeClient = new YoutubeClient();
            var video = await youtubeClient.Videos.Streams.GetManifestAsync(url);
            var streamInfo = video.GetMuxedStreams().GetWithHighestVideoQuality();
            
            try
            {
                Console.WriteLine("Начинаем скачивание видео");
                await youtubeClient.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
                Console.WriteLine("Скачивание видео окончено");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
