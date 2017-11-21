using System;
using System.Collections.Generic;
using System.Linq;
using ListProcessing.Core.Contracts;
using ListProcessing.Data;
using ListProcessing.Data.Contracts;
using ListProcessing.IO.Contracts;
using ListProcessing.Utilities;

namespace ListProcessing.Core
{
	public class Engine:IEngine
	{
		private IReader reader;
		private IWriter writer;
		private ICommandProcessor commandProcessor;
		private IDataStorage dataStorage;

		public Engine(IReader reader, IWriter writer,ICommandProcessor commandProcessor)
		{
			this.reader = reader;
			this.writer = writer;
			this.commandProcessor = commandProcessor;
		}

		public void Run()
		{
			this.InitialListInput();
			while (true)
			{
				var input = this.reader.ReadLine();
				if (input=="end")
				{
					this.writer.WriteLine(Constants.endMessage);
					break;
				}
				var commandArgs = input.Split(new char[' '], StringSplitOptions.RemoveEmptyEntries).ToList();
				var result = this.commandProcessor.ProccessCommand(this.dataStorage,commandArgs);
				this.writer.WriteLine(result);
			}
		}

		private void InitialListInput()
		{
			string input = this.reader.ReadLine();
			this.writer.WriteLine(input);
			var inputList = input.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
			this.dataStorage = new DataStorage(inputList,this.writer);
		}
		
	}
}
