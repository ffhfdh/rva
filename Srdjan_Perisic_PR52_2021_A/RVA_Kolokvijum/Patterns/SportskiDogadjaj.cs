using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.rva
{
	public abstract class SportskiDogadjaj
	{
		string tipSporta;
		ILogger log;


		public SportskiDogadjaj(ILogger log, string sport)
		{
			this.log = log;
			this.tipSporta = sport;
		}

		public string TipSporta 
		{
			get { return tipSporta; }
			set { tipSporta = TipSporta; }
		}

		protected internal abstract void IzlazakIgraca();

		protected internal abstract void TokIgre(string rezultat);

		protected internal abstract void ProglasenjePobedinika();

		protected internal abstract void Intervju();

		public void IzvrsiDogadjaj(string rezultat)
		{
			IzlazakIgraca();
			TokIgre(rezultat);
			ProglasenjePobedinika();
			Intervju();
		}
	}
}
