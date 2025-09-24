using Kolokvijum.Zad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokvijumGrupaA
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new LoggerTXT();

            Igrac i1 = new Igrac("Pera", "Peric", "065123456");
            Igrac i2 = new Igrac("Mika", "Mikic", "066001007");

            // konkretne figure u zadatku
            Figura konj = new Konj();
            Figura lovac = new Lovac(); // koristim za testiranje
            Figura piun = new Piun(); // koristim za testiranje
            Figura top = new Top();

            PotezKomanda komanda = new PotezKomanda(logger, lovac, i1);

            lovac.PotezFigure();
            piun.PotezFigure();

            komanda.PovuciPotez(i1, lovac);
            komanda.PovuciPotez(i2, piun);

            logger.Log(komanda);

            Console.WriteLine("Partija je zavrsena.");
            Console.ReadKey();
        }
    }
}
