using System.Collections.Generic;
using ListProcessing.Data.Contracts;
using ListProcessing.Utilities;

namespace ListProcessing.Commands
{
	public class AppendCommand : Command
	{

		public AppendCommand(IDataStorage dataStorage, IList<string> argsList) : base(dataStorage, argsList)
		{
		}

		public override string Execute()
		{
			var listCount = this.dataStorage.Count();

			if (this.commandArgs.Count != 1)
			{
				return Constants.invalidParametersCountMessage;
			}
			var text = this.commandArgs[0];
			this.dataStorage.Insert(listCount, text);

			return this.dataStorage.JoinedList();
		}
	}
}
