using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.GrupaB
{
	public interface IPoslasticarnicaFactory
	{
		IKolaci NapraviFrancuskiKolac();

		IKolaci NapraviItalijanskiKolac();

		void NapraviTurskiKolac();
	}
}
