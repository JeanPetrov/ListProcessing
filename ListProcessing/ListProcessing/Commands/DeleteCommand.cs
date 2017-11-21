namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using ListProcessing.Data.Contracts;
    using ListProcessing.Utilities;

    class DeleteCommand : Command
    {
        public DeleteCommand(IDataStorage dataStorage, IList<string> argsList) : base(dataStorage, argsList)
        {
        }

		public override string Execute()
		{
			var listCount = this.dataStorage.Count();

			bool isNumeric = int.TryParse(this.commandArgs[0], out int variable);

			if (this.commandArgs.Count != 1 || !isNumeric)
			{
				return Constants.invalidParametersCountMessage;
			}

			if (variable < 0 || variable > listCount - 1)
			{
				return $"Error: invalid index {variable}";
			}

			this.dataStorage.Remove(variable);

			return this.dataStorage.JoinedList();
		}
	}
}
