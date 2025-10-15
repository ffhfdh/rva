using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.rva
{
    public class Kosarka : SportskiDogadjaj
    {
        public Kosarka(ILogger log, string tipSporta):base(log, tipSporta)
        {

        }

        protected internal override void Intervju()
        {
            Console.WriteLine("Intervju sa trenerom.");
        }

        protected internal override void IzlazakIgraca()
        {
            Console.WriteLine("Izlazak igraca.");
        }

        protected internal override void ProglasenjePobedinika()
        {
            Console.WriteLine("Proglasenje pobednika.");
        }

        protected internal override void TokIgre(string rezultat)
        {
            Console.WriteLine("Korarkaski mec");
            //poziv logera 
        }
    }
}
