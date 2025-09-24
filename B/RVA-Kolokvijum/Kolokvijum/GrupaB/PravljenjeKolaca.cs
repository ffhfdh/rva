using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.GrupaB
{
	public abstract class PravljenjeKolaca
	{
		protected ILogger logger;

		public void NapraviKolac()
		{
			throw new NotImplementedException();
		}

		protected abstract void PripremaTesta();

		protected abstract void Pecenje(int temperatura, string vrstaPeci);

		protected abstract void Dekoracija();

		protected abstract void Serviranje();
	}
}
