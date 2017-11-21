using System.Collections.Generic;

namespace ListProcessing.Data.Contracts
{
	public interface IDataStorage
	{

        void Reverse();

        void Sort();

		void Insert(int position, string text);

		int Count();

		void Remove(int position);

		string GetLast();

		string GetFirst();

		string JoinedList();

		string CountOccurs(string pattern);
	}
}
