using System;
using System.Collections.Generic;
using System.Text;

namespace KolPriprema.Zad1
{
    public class LowResStrategy : IPlaybackStrategy
    {
        public void Play(string title)
        {
            Console.WriteLine($"Playing {title} in low res");
        }
    }
}
