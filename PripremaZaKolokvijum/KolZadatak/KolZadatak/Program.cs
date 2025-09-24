using KolPriprema.Zad1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerTXT logger = new LoggerTXT();
            VideoFactory factory = new VideoFactory(logger);

            VideoData video1 = factory.GetVideo("Interstellar", "Sci-Fi", 169);
            VideoData video2 = factory.GetVideo("Matrix", "Action", 136);
            VideoData video3 = factory.GetVideo("Interstellar", "Sci-Fi", 169);

            PlaybackInstance playback1 = new PlaybackInstance(video1, new LowResStrategy(), logger);
            PlaybackInstance playback2 = new PlaybackInstance(video2, new UltraHDStrategy(), logger);
            PlaybackInstance playback3 = new PlaybackInstance(video3, new HDStrategy(), logger);

            playback1.Play();
            playback2.Play();
            playback3.Play();

            Console.ReadKey();
        }
    }
}
