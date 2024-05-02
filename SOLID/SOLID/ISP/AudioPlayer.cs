using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID.ISP.IMediaPlayer;

namespace SOLID.ISP
{
    internal class AudioPlayer:IAudioPlayer
    {
        public void PlayAudio()
        {
            Console.WriteLine("Play Audio Method From AudioPlayer Class");
        }
        
    }
}
