using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.GrupaB
{
    public class ItalijaFactory : IPoslasticarnicaFactory
    {
        public void NapraviKolac()
        {
            new ItalijanskiKolaci(new LoggerTxt()).NapraviKolac();
        }
    }
}
