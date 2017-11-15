using System;
using ListProcessing.IO.Contracts;

namespace ListProcessing.IO
{
	public class Reader : IReader
	{
		public string ReadLine()
		{
			string input = Console.ReadLine();
			return input;
		}
	}
}
