using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.Zad
{
	public class PotezKomanda : IPotezKomanda
	{
		// mora da se proslijedi koja je figura i da se cuva u datoteku da je potez povucen
		ILogger logger;
		Figura figura;
		PotezKomanda komanda;
		Igrac igrac;

		public PotezKomanda(ILogger logger, Figura figura, Igrac igrac)
		{
			this.logger = logger;
			this.figura = figura;
			this.igrac = igrac;
		}

        public void PovuciPotez(Igrac igrac, Figura figura)
        {
			Console.WriteLine($"{igrac} je povukao potez figure - {figura}.");
			logger.Log(komanda);
        }
    }
}
