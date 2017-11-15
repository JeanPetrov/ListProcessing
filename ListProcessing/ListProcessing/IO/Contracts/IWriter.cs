using System.Collections.Generic;

namespace ListProcessing.IO.Contracts
{
	public interface IWriter
	{
		void WriteLine(string output);

		void JoinedWriteLine(IList<string> list);
	}
}
