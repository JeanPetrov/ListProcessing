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

        public void Reverse()
        {
           this.list = Enumerable.Reverse(this.list).ToList();
        }

        public void Sort()
        {
            this.list = this.list.OrderBy(x => x).ToList();
        }
		public void Insert(int position, string text)
		{
			this.list.Insert(position, text);
		}

		public void Remove(int position)
		{
			this.list.RemoveAt(position);
		}

		public int Count()
		{
			return this.list.Count();
		}

		public string GetFirst()
		{
			return this.list[0];
		}

		public string GetLast()
		{
			return this.list[this.Count() - 1];
		}

		public string JoinedList()
		{
			return string.Join(" ", this.list);
		}

		public string CountOccurs(string pattern)
		{
			return this.list.Where(w => w == pattern).Count().ToString();
		}
	}
}
