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
            if (this.commandArgs.Count != 2 || int.Parse(commandArgs[0]) < 0)
            {
                return Constants.invalidParametersCountMessage;
            }
            this.dataStorage.List.Insert(int.Parse(this.commandArgs[0]), this.commandArgs[1]);

            return string.Join(" ", this.dataStorage.List);
        }
    }
}