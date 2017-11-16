using System.Collections.Generic;

namespace ListProcessing.Data.Contracts
{
	public interface IDataStorage
	{
		void Add(string text);

        void Reverse();

		IList<string> List { get; }
	}
}
