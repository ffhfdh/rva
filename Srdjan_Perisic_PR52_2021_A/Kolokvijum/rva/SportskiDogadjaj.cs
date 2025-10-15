using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.rva
{
	public abstract class SportskiDogadjaj
	{
		string TipSporta;
		ILogger log;

		protected internal abstract void IzlazakIgraca();

		protected internal abstract void TokIgre();

		protected internal abstract void ProglasenjePobedinika();

		protected internal abstract void Intervju();

		public void IzvrsiDogadjaj()
		{
			throw new NotImplementedException();
		}
	}
}
