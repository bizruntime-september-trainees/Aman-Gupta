using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Title="Videoisencoded"};
            VideoEncoder videoencoder = new VideoEncoder();
            MailServies mailServies = new MailServies();
            MessageService messageService = new MessageService();

            videoencoder.videoencoded += mailServies.onvideoencoded;
            videoencoder.videoencoded += messageService.onvideoencoded;
            videoencoder.Encode(video);
        }
    }
   
}
