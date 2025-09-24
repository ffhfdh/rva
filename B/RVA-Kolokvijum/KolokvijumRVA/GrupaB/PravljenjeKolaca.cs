using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.GrupaB
{
	public abstract class PravljenjeKolaca
	{
        protected ILogger logger;

        protected PravljenjeKolaca(ILogger logger)
        {
            this.logger = logger;
        }

        public void NapraviKolac()
		{
			PripremaTesta();
			Pecenje();
			Dekoracija();
			Serviranje();
		}

		protected abstract void PripremaTesta();

		protected abstract void Pecenje();

		protected abstract void Dekoracija();

		protected abstract void Serviranje();
	}
}
