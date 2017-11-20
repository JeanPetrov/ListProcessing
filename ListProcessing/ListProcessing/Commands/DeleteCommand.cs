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
            if (this.commandArgs.Count != 1)
            {
                return Constants.invalidParametersCountMessage;
            }
            this.dataStorage.List.RemoveAt(int.Parse(commandArgs[0]));

            return string.Join(" ", this.dataStorage.List);
        }
    }
}
