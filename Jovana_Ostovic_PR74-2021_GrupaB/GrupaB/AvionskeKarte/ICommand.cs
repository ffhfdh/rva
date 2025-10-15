using System;
using System.Collections.Generic;
using System.Text;

namespace GrupaB.AvionskeKarte
{
	public interface ICommand
	{
		void Execute();

		void Undo();
	}
}
