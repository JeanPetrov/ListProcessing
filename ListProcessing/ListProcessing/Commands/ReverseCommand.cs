namespace ListProcessing.Commands
{
    using Data.Contracts;
    using Utilities;
    using System.Collections.Generic;

    public class ReverseCommand : Command
    {
        public ReverseCommand(IDataStorage dataStorage, IList<string> argsList) : base(dataStorage, argsList)
        {

        }

        public override string Execute()
        {
            if (this.commandArgs.Count != 0)
            {
                return Constants.invalidParametersCountMessage;
            }

            this.dataStorage.Reverse();

            return string.Join(" ", this.dataStorage.List);
        }
    }
}
