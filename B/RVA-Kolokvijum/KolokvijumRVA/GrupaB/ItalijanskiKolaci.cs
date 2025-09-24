using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.GrupaB
{
    public class ItalijanskiKolaci : PravljenjeKolaca
    {
        public ItalijanskiKolaci(ILogger logger) : base(logger)
        {

        }
        
        protected override void Dekoracija()
        {
            Console.WriteLine("Dekorisanje italijanskog kolaca.");
        }

        protected override void Pecenje()
        {
            Console.WriteLine("Pecenje italijanskog kolaca na 200 stepeni u peci...");
        }

        protected override void PripremaTesta()
        {
            Console.WriteLine("Priprema testa za italijanski kolac: 15 minuta.");
        }

        protected override void Serviranje()
        {
            Console.WriteLine("Serviranje italijanskog kolaca.");
            logger.Log("Serviran italijanski kolac.");
        }
    }
}
