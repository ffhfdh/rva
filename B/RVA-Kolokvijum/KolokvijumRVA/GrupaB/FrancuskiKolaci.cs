using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.GrupaB
{
    public class FrancuskiKolaci : PravljenjeKolaca
    {
        public FrancuskiKolaci(ILogger logger):base(logger)
        {

        }
        protected override void Dekoracija()
        {
            Console.WriteLine("Dekorisanje francuskog kolaca.");
        }

        protected override void Pecenje()
        {
            Console.WriteLine("Pecenje francuskog kolaca na 120 stepeni u peci...");
        }

        protected override void PripremaTesta()
        {
            Console.WriteLine("Priprema testa za francuski kolac: 10 minuta.");
        }

        protected override void Serviranje()
        {
            Console.WriteLine("Serviranje francuskog kolaca.");
            logger.Log("Serviran francuski kolac.");
        }
    }
}
