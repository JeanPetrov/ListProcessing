using ListProcessing.Core;
using ListProcessing.Core.Contracts;
using ListProcessing.Data;
using ListProcessing.Data.Contracts;
using ListProcessing.IO;
using ListProcessing.IO.Contracts;

namespace ListProcessing
{
	class StartUp
	{
		static void Main()
		{
			IWriter writer = new Writer();
			IReader reader = new Reader();
			ICommandProcessor commandProcessor = new CommandProcessor();

			IEngine engine = new Engine(reader,writer,commandProcessor);

			engine.Run();

		}
	}
}
