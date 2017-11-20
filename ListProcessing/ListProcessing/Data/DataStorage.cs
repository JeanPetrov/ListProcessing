namespace ListProcessing.Data
{
    using System.Linq;
    using System;
    using System.Collections.Generic;
    using Data.Contracts;
    using IO.Contracts;

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

        public void Reverse()
        {
           this.list = Enumerable.Reverse(this.list).ToList();
        }

        public void Sort()
        {
            this.list = this.list.OrderBy(x => x).ToList();
        }

		public IList<string> List
		{
			get { return this.list; }
		}
	}
}
