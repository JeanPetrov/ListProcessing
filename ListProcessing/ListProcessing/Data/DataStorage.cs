using System;
using System.Collections.Generic;
using ListProcessing.Data.Contracts;
using ListProcessing.IO.Contracts;

namespace ListProcessing.Data
{
	public class DataStorage:IDataStorage
	{

		private IList<String> list;
		private IWriter writer;

		public DataStorage(IList<string> inputList,IWriter writer)
		{
			this.list = new List<string>(inputList);
			this.writer = writer;
		}

		public void Add(string text)
		{
			this.list.Add(text);
		}

		public IList<string> List
		{
			get { return this.list; }
		}
	}
}
