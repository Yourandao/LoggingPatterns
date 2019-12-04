using LoggingPatterns.Components.Enums;
using LoggingPatterns.Components.Factory;

namespace LoggingPatterns {
	public class Program {
		private static void Main(string[] args) {
			AbstractFactory f = FactoryProducer.GetFactory(SaverType.Console);
			var a = f.GetLogSaver("postgres");
			f = FactoryProducer.GetFactory(SaverType.Email);
			var b = f.GetLogSaver("EMAIL");

			a.Next(b)
		}
	}
}
