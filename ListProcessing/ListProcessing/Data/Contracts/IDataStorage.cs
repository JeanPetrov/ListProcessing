using System.Collections.Generic;

namespace ListProcessing.Data.Contracts
{
	public interface IDataStorage
	{
		void Add(string text);

		IList<string> List { get; }
	}
}
