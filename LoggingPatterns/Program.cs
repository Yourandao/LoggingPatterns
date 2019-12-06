using System;
using LoggingPatterns.Components.Enums;
using LoggingPatterns.Components.Factory;

namespace LoggingPatterns {
	public class Program {
		private static void Main(string[] args) {
			AbstractFactory f = FactoryProducer.GetFactory(SaverType.Database);
			var a = f.GetLogSaver("POSTGRES");

			f = FactoryProducer.GetFactory(SaverType.Console);
			var b = f.GetLogSaver("CONSOLE");

            f = FactoryProducer.GetFactory(SaverType.Database);
            var c = f.GetLogSaver("MONGO");

            a.SetNext(b).SetNext(c);

            a.Handle(LogType.Debug);

            Console.ReadKey();
        }
	}
}
