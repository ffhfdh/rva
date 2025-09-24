using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KolPriprema.Zad1
{
    public class LoggerTXT : ILogger
    {
        public void Log(VideoData data)
        {
            using (StreamWriter sw = new StreamWriter("activityLog.txt", true))
            {
                sw.WriteLine($"[LOG] {DateTime.Now.ToString("dd-mm-yyyy HH:mm:ss")}: {data.Title} ({data.Genre}, {data.Duration} min) accessed/played");
            }
        }
    }
}
