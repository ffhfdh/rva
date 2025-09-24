using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.GrupaB
{
    public class TurskiKolaci : PravljenjeKolaca
    {
        public TurskiKolaci(ILogger logger):base(logger)
        {

        }
        protected override void Dekoracija()
        {
            Console.WriteLine("Dekorisanje turskog kolaca.");
        }

        protected override void Pecenje()
        {
            Console.WriteLine("Pecenje turskog kolaca na 170 stepeni u peci...");
        }

        protected override void PripremaTesta()
        {
            Console.WriteLine("Priprema testa za turski kolac: 12 minuta.");
        }

        protected override void Serviranje()
        {
            Console.WriteLine("Serviranje turskog kolaca.");
            logger.Log("Serviran turski kolac.");
        }
    }
}
