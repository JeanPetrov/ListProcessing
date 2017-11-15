using System;
using System.Collections.Generic;
using ListProcessing.IO.Contracts;

namespace ListProcessing.IO
{
	public class Writer : IWriter
	{
		public void WriteLine(string output)
		{
			Console.WriteLine(output);
		}

		public void JoinedWriteLine(IList<string> list)
		{
			Console.WriteLine(string.Join(" ",list));
		}
	}
}
