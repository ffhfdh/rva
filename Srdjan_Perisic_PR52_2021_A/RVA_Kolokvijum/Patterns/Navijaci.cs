using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.rva
{
	public class Navijaci : IObserverDogadjaja
	{
		string ime;
		string godine;
		string navijackiTim;

        public Navijaci(string ime, string godine, string navijackiTim)
        {
            this.ime = ime;
            this.godine = godine;
            this.navijackiTim = navijackiTim;
        }


        public void Update(string semafor)
        {
            Console.WriteLine("Promena rezultata: ", semafor);
        }
    }
}
