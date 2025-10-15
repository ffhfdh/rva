using GrupaB.AvionskeKarte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvijum
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandManager manager = new CommandManager();
            ILogger loger = new TxtLogger();
            Rezervacije rezervacije = new Rezervacije(loger);
            INacinPlacanja nacinPlacanja = new BiznisCijenaPlacanje();
            ICommand RezervisiKomanda = new RezervisiKomanda(rezervacije, "Petar", "17a", new Let("147", "Kompanija", 125.3), nacinPlacanja, 123.5 );

            manager.ExecuteCommand(RezervisiKomanda);
            manager.Undo();






            Console.ReadKey();
        }
    }
}
