using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Kolokvijum.Zad
{
    public class LoggerTXT : ILogger
    {
        public void Log(PotezKomanda potezKomanda)
        {
            using (StreamWriter sw = new StreamWriter("sah.txt", true))
            {
                sw.WriteLine($"[LOG]: {DateTime.Now: dd:MM:yyyy hh:mm:ss} igrac je ponistio potez - {potezKomanda} .");
            }
        }
    }
}
