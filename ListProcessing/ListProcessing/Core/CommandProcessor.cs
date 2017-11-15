using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ListProcessing.Commands.Contracts;
using ListProcessing.Core.Contracts;
using ListProcessing.Data.Contracts;
using ListProcessing.Utilities;

namespace ListProcessing.Core
{
	public class CommandProcessor : ICommandProcessor
	{
		private IDataStorage dataStorage;

		public string ProccessCommand(IDataStorage dataStorage, IList<string> commandArgs)
		{
			var args = commandArgs[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var command = args[0];
			var fullCommand = command + Constants.commandSuffix;

			Type commandClass;
			try
			{
				commandClass = Assembly.GetExecutingAssembly().GetTypes().First(c => c.Name.ToLower() == fullCommand);
			}
			catch (Exception e)
			{
				return Constants.invalidCommandMessage;
			}
			var ctors = commandClass.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
			ICommand provider = (ICommand)ctors[0].Invoke(new object[] { dataStorage, args.Skip(1).ToList() });
			var result = provider.Execute();
			return result;
		}
	}
}
