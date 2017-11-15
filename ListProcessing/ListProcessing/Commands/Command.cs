using System.Collections.Generic;
using ListProcessing.Commands.Contracts;
using ListProcessing.Data.Contracts;

namespace ListProcessing.Commands
{
	public abstract class Command:ICommand
	{
		protected IDataStorage dataStorage;
		protected IList<string> commandArgs;

		public Command(IDataStorage dataStorage, IList<string> argsList)
		{
			this.dataStorage = dataStorage;
			this.commandArgs = argsList;
		}

		public abstract string Execute();
	}
}
