using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Kolokvijum.GrupaB
{
    public class LoggerTxt : ILogger
    {
        string putanja = "kolokvijum.txt";


        public void Log(string poruka)
        {
            using(StreamWriter writer = new StreamWriter(putanja))
            {
                writer.WriteLine($"{poruka}");
            }
        }
    }
}
