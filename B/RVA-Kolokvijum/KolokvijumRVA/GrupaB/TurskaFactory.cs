using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.GrupaB
{
    public class TurskaFactory : IPoslasticarnicaFactory
    {
        public void NapraviKolac()
        {
             new TurskiKolaci(new LoggerTxt()).NapraviKolac();
        }
    }
}
