namespace ListProcessing.Commands
{
    using Data.Contracts;
    using Utilities;
    using System.Collections.Generic;

    public class InsertCommand : Command
    {
        public InsertCommand(IDataStorage dataStorage, IList<string> argsList) : base(dataStorage, argsList)
        {

        }

		public override string Execute()
		{
			var listCount = this.dataStorage.Count();

			bool isNumeric = int.TryParse(this.commandArgs[0], out int variable);

			if (this.commandArgs.Count != 2 || !isNumeric)
			{
				return Constants.invalidParametersCountMessage;
			}

			if (variable < 0 || variable > listCount - 1)
			{
				return $"Error: invalid index {variable}";
			}
			this.dataStorage.Insert(variable, this.commandArgs[1]);

			return this.dataStorage.JoinedList();
		}
	}
}