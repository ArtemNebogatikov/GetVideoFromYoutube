using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GetVideoFromYoutube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите ссылку на видео, по которому необходимо получить информацию и скачать");
            Console.WriteLine();
            var url = Console.ReadLine();

            VideoFromYoutube video = new VideoFromYoutube();
            Command getInfo = new GetInfo(url);
            video.SetCommand(getInfo);
            video.Execute();
            Command getVideo = new DownloadVideo(url);
            video.SetCommand(getVideo);
            video.Execute();
            Console.ReadLine();
        }
    }
}
