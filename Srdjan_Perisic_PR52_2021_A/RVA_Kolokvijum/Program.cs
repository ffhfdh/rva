using Kolokvijum.rva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RVA_Kolokvijum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ILogger logger = new LoggerTxt();

            Semafor semafor = new Semafor();
            IObserverDogadjaja novinar1 = new Novinar("Novinar1", "RTS", true);
            IObserverDogadjaja novinar2 = new Novinar("Novinar2", "RTV", false);
            IObserverDogadjaja navijaci1 = new Navijaci("Marko", "22", "Vojvodina");
            IObserverDogadjaja navijaci2 = new Navijaci("Nikola", "25", "Radnicki");
            IObserverDogadjaja navijaci3 = new Navijaci("Filip", "30", "TSC");

            Kosarka kosarka = new Kosarka(logger, "Kosarka");
            Fudbal fudbal = new Fudbal(logger, "Fudbal");

            semafor.RegisterObserver(novinar1);
            semafor.RegisterObserver(novinar2);
            semafor.RegisterObserver(navijaci1);
            semafor.RegisterObserver(navijaci2);
            semafor.RegisterObserver(navijaci3);

            for (int i = 0; i < 5; i++)
            {
                semafor.PromeniReultat("");
                Console.WriteLine("*********************");
                Thread.Sleep(1000);
            }

            semafor.UnregisterObserver(novinar1);
            semafor.UnregisterObserver(novinar2);
            semafor.UnregisterObserver(navijaci1);
            semafor.UnregisterObserver(navijaci2);
            semafor.UnregisterObserver(navijaci3);
            Console.ReadKey();
        }
    }
}



