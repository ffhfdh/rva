using System;
using System.Collections.Generic;
using System.Text;

namespace KolPriprema.Zad1
{
	public class VideoFactory
	{
		ILogger Logger;

		private Dictionary<string, VideoData> cache;

        public VideoFactory(ILogger logger)
        {
            Logger = logger;
			cache = new Dictionary<string, VideoData>();
		}

        public VideoData GetVideo(string title, string genre, int duration)
		{
			if(!cache.ContainsKey(title))
            {
				cache.Add(title, new VideoData(title, genre, duration));
            }
			Logger.Log(cache[title]);
			return cache[title];
		}
	}
}
