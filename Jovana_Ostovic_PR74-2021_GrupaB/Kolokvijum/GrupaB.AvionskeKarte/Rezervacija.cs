using System;
using System.Collections.Generic;
using System.Text;

namespace GrupaB.AvionskeKarte
{
	public class Rezervacija
	{
		private string imePutnika;
		private Let let;
		private string brojSjedista;
		private double cijenaKarte;
        
		private  INacinPlacanja nacinPlacanja;



		public Rezervacija(string imePutnika, Let let, string brojSjedista, double cijenaKarte, INacinPlacanja nacinPlacanja)
        {
			this.ImePutnika = imePutnika;
			this.Let = let;
			this.BrojSjedista = brojSjedista;
			this.CijenaKarte = cijenaKarte;
			this.NacinPlacanja = nacinPlacanja;
        }

        public string ImePutnika { get => imePutnika; set => imePutnika = value; }
        public Let Let { get => let; set => let = value; }
        public string BrojSjedista { get => brojSjedista; set => brojSjedista = value; }
        public double CijenaKarte { get => cijenaKarte; set => cijenaKarte = value; }
        public INacinPlacanja NacinPlacanja { get => nacinPlacanja; set => nacinPlacanja = value; }

        public override string ToString()
        {
            return $"{ImePutnika} - {Let} - {BrojSjedista} - {CijenaKarte}";
        }

		public double OdrediPlacanje()
        {
            return nacinPlacanja.OdrediCijenu(cijenaKarte);
        }
    }
}
