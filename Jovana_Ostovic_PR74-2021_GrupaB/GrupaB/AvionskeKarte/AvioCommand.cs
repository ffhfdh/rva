using System;
using System.Collections.Generic;
using System.Text;

namespace GrupaB.AvionskeKarte
{
	public abstract class AvioCommand : Rezervacije, ICommand
	{
		protected Rezervacije receiver;
		protected int brojSjedista;
	}
}
