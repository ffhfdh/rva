using System;
using System.Collections.Generic;
using System.Text;

namespace GrupaB.AvionskeKarte
{
	public class Let
	{
		private string brojLeta;
		private string kompanija;
		private double osnovnaCijenaKarte;

		public Let(string brojLeta, string kompanija, double cijena)
        {
			this.BrojLeta = brojLeta;
			this.Kompanija = kompanija;
			OsnovnaCijenaKarte = cijena;
        }

        public string BrojLeta { get => brojLeta; set => brojLeta = value; }
        public string Kompanija { get => kompanija; set => kompanija = value; }
        public double OsnovnaCijenaKarte { get => osnovnaCijenaKarte; set => osnovnaCijenaKarte = value; }

        public override string ToString()
        {
			return $"LET {BrojLeta} - {Kompanija} - {OsnovnaCijenaKarte} ";
        }
    }
}
