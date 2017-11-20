namespace ListProcessing.Commands
{
    using Data.Contracts;
    using Utilities;
    using System.Collections.Generic;
    using System.Linq;

    public class CountCommand : Command
    {
        public CountCommand(IDataStorage dataStorage, IList<string> argsList) : base(dataStorage, argsList)
        {

        }

        public override string Execute()
        {
            if (this.commandArgs.Count != 1)
            {
                return Constants.invalidParametersCountMessage;
            }

            return this.dataStorage.List.Where(w => w == this.commandArgs[0]).Count().ToString();
        }
    }
}
