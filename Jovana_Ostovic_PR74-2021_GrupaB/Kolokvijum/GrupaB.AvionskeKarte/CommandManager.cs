using System;
using System.Collections.Generic;
using System.Text;

namespace GrupaB.AvionskeKarte
{
	public class CommandManager
	{
		private Stack<ICommand> undoStack;
		private Stack<ICommand> redoStack;


		public CommandManager()
        {
			undoStack = new Stack<ICommand>();
			redoStack = new Stack<ICommand>();
		}
		public void ExecuteCommand(ICommand command)
		{
			command.Execute();
			undoStack.Push(command);
		}

		public void Undo()
		{
            if (undoStack.Count > 0)
            {
				ICommand command = undoStack.Pop();
				command.Execute();
				redoStack.Push(command);
            }
		}

		public void Redo()
		{
			if (redoStack.Count > 0)
			{
				ICommand command = redoStack.Pop();
				command.Execute();
				undoStack.Push(command);
			}
		}
	}
}
