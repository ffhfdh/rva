using System;
using System.Collections.Generic;
using System.Text;

namespace KolPriprema.Zad1
{
	public class VideoData
	{
		public string Title;
		public string Genre;
		public int Duration;

		public VideoData(string title, string genre, int duration)
		{
			this.Title = title;
			this.Genre = genre;
			this.Duration = duration;
		}
	}
}
