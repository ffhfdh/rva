using System;
using System.Collections.Generic;
using System.Text;

namespace GrupaB.AvionskeKarte
{
	public class CommandManager
	{
		private stack<ICommand> undoStack;
		private Stack<ICommand> redoStack;

		public void ExecuteCommand(ICommand command)
		{
			throw new NotImplementedException();
		}

		public void Undo()
		{
			throw new NotImplementedException();
		}

		public void Redo()
		{
			throw new NotImplementedException();
		}
	}
}
