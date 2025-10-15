using System;
using System.Collections.Generic;
using System.Text;

namespace GrupaB.AvionskeKarte
{
	public abstract class AvioCommand :ICommand
	{
		protected Rezervacije receiver;
		protected string brojSjedista;
		protected string putnik;
		protected Let let;
		protected INacinPlacanja nacinPlacanja;
		protected double cijena;

        public abstract void Execute();
        public abstract void Undo();
    }
}
