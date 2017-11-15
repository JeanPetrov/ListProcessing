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
			if (this.commandArgs.Count!=1)
			{
				return Constants.invalidParametersCountMessage;
			}
			var text = this.commandArgs[0];
			this.dataStorage.Add(text);
			return string.Join(" ",this.dataStorage.List);
		}


		
	}
}
