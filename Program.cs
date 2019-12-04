using LoggingPatterns.Components.Enums;
using LoggingPatterns.Components.Factory;

namespace LoggingPatterns {
	public class Program {
		private static void Main(string[] args) {
			AbstractFactory f = FactoryProducer.GetFactory(SaverType.Console);

		}
	}
}
