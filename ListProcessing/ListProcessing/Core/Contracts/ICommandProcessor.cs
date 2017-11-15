using System.Collections.Generic;
using ListProcessing.Data.Contracts;

namespace ListProcessing.Core.Contracts
{
	public interface ICommandProcessor
	{
		string ProccessCommand(IDataStorage dataStorage,IList<string> commandArgs);
	}
}
