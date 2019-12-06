using LoggingPatterns.Components.Factory;
using System;
using System.Collections.Generic;
using LoggingPatterns.Components.Enums;

namespace LoggingPatterns
{
	public class Program
	{
		private static void Main(string[] args)
		{
			AbstractFactory factory = FactoryProducer.GetFactory(SaverType.Database);

			var mongoSaver = factory.GetLogSaver("MONGO");

			factory = FactoryProducer.GetFactory(SaverType.Console);

			var consoleSaver = factory.GetLogSaver("MESSAGEBOX");

			mongoSaver.SetNext(consoleSaver);

			List<string> logs = new List<string>()
			{
				"info debug 12301 123jlkasdlaksasldfkj",
				"[DEBUG] alskdjalsdj1 123123 jalskdjflaskdfj"
			};

			for (int i = 0; i < logs.Count; i++)
			{
				mongoSaver.Handle(logs[i]);
			}

			Console.ReadKey();
		}
	}
}
