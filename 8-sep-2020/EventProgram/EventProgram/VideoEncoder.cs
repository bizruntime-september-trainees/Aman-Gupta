using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventProgram
{
    class VideoEncoder
    {
        public delegate void videoEncodeEventHandler(object source, EventArgs args);

        public event videoEncodeEventHandler videoencoded;
        public void Encode(EventProgram.Video video)
        {
            Console.WriteLine("Video is encoding");
            Thread.Sleep(5000);
            onvideoencoded();
        }
        protected virtual void onvideoencoded()
        {
            if(videoencoded !=null)
            {
                videoencoded(this, EventArgs.Empty);
            }
        }
    }
}
