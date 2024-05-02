using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    internal interface IMediaPlayer
    {

        // Interface for playing audio
        public interface IAudioPlayer
        {
            void PlayAudio();
        }

        // Interface for playing video
        public interface IVideoPlayer
        {
            void PlayVideo();
        }

        // Interface for displaying subtitles
        public interface ISubtitlePlayer
        {
            void DisplaySubtitles();
        }

        // Interface for loading media
        public interface IMediaLoader
        {
            void LoadMedia(string filePath);
        }

        
        public interface IMediaPlayer : IAudioPlayer, IVideoPlayer, ISubtitlePlayer
        {
            
        }

      

    }
}
