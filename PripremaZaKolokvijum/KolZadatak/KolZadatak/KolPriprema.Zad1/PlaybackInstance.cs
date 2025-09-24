using System;
using System.Collections.Generic;
using System.Text;

namespace KolPriprema.Zad1
{
	public class PlaybackInstance
	{
		private VideoData data;
		private IPlaybackStrategy strategy;
		private ILogger Logger;

		public PlaybackInstance(VideoData data, IPlaybackStrategy strategy, ILogger logger)
		{
			this.data = data;
			this.strategy = strategy;
			this.Logger = logger;
		}

		public void Play()
		{
			strategy.Play(data.Title);
			Logger.Log(data);
		}
	}
}
