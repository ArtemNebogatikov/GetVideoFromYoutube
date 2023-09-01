using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace GetVideoFromYoutube
{
    class GetInfo : Command
    {
        private string url;
        public GetInfo(string url) 
        {
            this.url = url;
        }
        public override void Run()
        {
            var youtubeClient = new YoutubeClient();
            var video = youtubeClient.Videos.GetAsync(url);
            var title = video.Result.Title;
            var info = video.Result.Description;
            Console.WriteLine(title);
            Console.WriteLine(info);
        }
    }
}
