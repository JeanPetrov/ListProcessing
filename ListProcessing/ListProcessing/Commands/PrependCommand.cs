namespace ListProcessing.Commands
{
    using Data.Contracts;
    using Utilities;
    using System.Collections.Generic;

    public class PrependCommand : Command
    {
        public PrependCommand(IDataStorage dataStorage, IList<string> argsList) : base(dataStorage, argsList)
        {

        }

        public override string Execute()
        {
            if (this.commandArgs.Count != 1)
            {
                return Constants.invalidParametersCountMessage;
            }
            this.dataStorage.List.Insert(0, this.commandArgs[0]);

            return string.Join(" ", this.dataStorage.List);
        }
    }
}