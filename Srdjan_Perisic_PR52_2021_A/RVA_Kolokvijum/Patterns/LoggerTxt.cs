using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Kolokvijum.rva
{
    public class LoggerTxt : ILogger
    {
        public void Log(string text)
        {
            string filePath = "rva.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("LOG: ", text);
            }
        }
    }
}
