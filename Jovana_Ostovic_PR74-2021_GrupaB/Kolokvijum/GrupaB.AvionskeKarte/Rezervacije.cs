using System;
using System.Collections.Generic;
using System.Text;

namespace GrupaB.AvionskeKarte
{
	public class Rezervacije
	{
		private List<Rezervacija> rezervacije;
		private ILogger loger;

		public Rezervacije(ILogger loger)
        {
			this.loger = loger;
			rezervacije = new List<Rezervacija>();
        }

		public void Izmijeni(string putnik, Let let,string brojSjedista, string novoSjediste)
		{
			foreach (Rezervacija r in rezervacije)
			{
				if (r.ImePutnika.Equals(putnik) && let.BrojLeta.Equals(r.Let.BrojLeta) && brojSjedista.Equals(r.BrojSjedista))
				{
					r.BrojSjedista = novoSjediste;
					return;
				}
			}
		}

		public void Rezervisi(string putnik, Let let, string sjediste, double cijena, INacinPlacanja nacinPlacanja)
		{
			Rezervacija r = new Rezervacija(putnik, let, sjediste, cijena, nacinPlacanja);
			rezervacije.Add(r);
			loger.Log(r);
		}

		public void Otkazi(string putnik, Let let, string brojSjedista)
		{
			foreach(Rezervacija r in rezervacije)
            {
				if(r.ImePutnika.Equals(putnik) && let.BrojLeta.Equals(r.Let.BrojLeta) && brojSjedista.Equals(r.BrojSjedista))
                {
					rezervacije.Remove(r);
					return;
                }
            }
		}
	}
}
