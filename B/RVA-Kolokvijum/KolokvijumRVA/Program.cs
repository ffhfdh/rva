using Kolokvijum.GrupaB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokvijumRVA
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new LoggerTxt();
            IPoslasticarnicaFactory francuskaFactory = new FrancuskaFactory();
            IPoslasticarnicaFactory italijaFactory = new ItalijaFactory();
            IPoslasticarnicaFactory turskaFactory = new TurskaFactory();

            /*Console.WriteLine("Pravljenje francuskog kolaca.\n");
            PravljenjeKolaca francuskiKolac = new FrancuskiKolaci();
            francuskiKolac.NapraviKolac();

            Console.WriteLine("Pravljenje italijanskog kolaca.\n");
            PravljenjeKolaca italijanskiKolac = new ItalijanskiKolaci();
            italijanskiKolac.NapraviKolac();

            Console.WriteLine("Pravljenje turskog kolaca.\n");
            PravljenjeKolaca turskiKolac = new TurskiKolaci();
            turskiKolac.NapraviKolac();*/

            
            francuskaFactory.NapraviKolac();
            italijaFactory.NapraviKolac();
            turskaFactory.NapraviKolac();


            Console.ReadKey();
        }
    }
}
