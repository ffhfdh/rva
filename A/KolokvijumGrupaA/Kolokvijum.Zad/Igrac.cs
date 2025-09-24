using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.Zad
{
	public class Igrac : Sahista
	{
		public string Ime;
		public string Prezime;
		public string BrojTelefona;

		// konstruktor sa parametrima

		public Igrac(string ime, string prezime, string brojTelefona)
		{
			this.Ime1 = ime;
			this.Prezime1 = prezime;
			this.BrojTelefona1 = brojTelefona;
		}

		// property za svako polje klase

        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
        public string BrojTelefona1 { get => BrojTelefona; set => BrojTelefona = value; }
    }
}
