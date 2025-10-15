using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.rva
{
	public class Novinar : IObserverDogadjaja
	{
		string ime;
		string mediji;
		bool potrebanSnimatelj;


        public Novinar(string ime, string mediji, bool potrebanSnimatelj)
        {
            this.ime = ime;
            this.mediji = mediji;
            this.potrebanSnimatelj = potrebanSnimatelj;
        }


        public void Update(string semafor)
        {
            Console.WriteLine("Promena rezultata: ", semafor);
        }
    }
}
