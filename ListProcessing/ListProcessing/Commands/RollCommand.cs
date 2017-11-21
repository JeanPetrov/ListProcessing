using System;
using System.Collections.Generic;
using ListProcessing.Data.Contracts;
using ListProcessing.Utilities;

namespace ListProcessing.Commands
{
	public class RollCommand : Command
	{
		public RollCommand(IDataStorage dataStorage, IList<string> argsList) : base(dataStorage, argsList)
		{

		}

		public override string Execute()
		{
			var listCount = this.dataStorage.Count();

			if (this.commandArgs.Count != 1)
			{
				return Constants.invalidParametersCountMessage;
			}
			if (this.commandArgs[0] == "left")
			{
				var temp = this.dataStorage.GetFirst();
				this.dataStorage.Remove(0);
				this.dataStorage.Insert(listCount - 1, temp);
			}
			else if (this.commandArgs[0] == "right")
			{
				var temp = this.dataStorage.GetLast();
				this.dataStorage.Remove(listCount - 1);
				this.dataStorage.Insert(0, temp);
			}
			else
			{
				return Constants.invalidCommandMessage;
			}

			return this.dataStorage.JoinedList();
		}
	}
}
