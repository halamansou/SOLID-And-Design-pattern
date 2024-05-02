using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID.ISP.IMediaPlayer;

namespace SOLID.ISP
{
    internal class MediaLoader : IMediaLoader
    {
        public void LoadMedia(string filePath)
        {
            Console.WriteLine("Loading Media Method From MediaLoader Class");
        }
    }
}
