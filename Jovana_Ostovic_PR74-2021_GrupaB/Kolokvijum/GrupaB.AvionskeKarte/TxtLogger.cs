using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GrupaB.AvionskeKarte
{
    public class TxtLogger : ILogger
    {
        private string filePath;
        public TxtLogger()
        {
            filePath = "exaple.txt";
        }
        public void Log(Rezervacija r)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{r.ImePutnika} - {r.Let} - {r.BrojSjedista}");
            }
        }
    }
}
