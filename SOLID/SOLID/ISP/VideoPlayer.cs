using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID.ISP.IMediaPlayer;

namespace SOLID.ISP
{
    internal class VideoPlayer :IVideoPlayer ,ISubtitlePlayer
    {
        public void PlayVideo()
        {
            Console.WriteLine("Play Video Method From VideoPlayer Class");
        }

        public void DisplaySubtitles()
        {
            Console.WriteLine("Display Subtitles Method From VideoPlayer Class");
        }
    }
}
