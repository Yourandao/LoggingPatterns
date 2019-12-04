using System;
using LoggingPatterns.Components.Enums;

namespace LoggingPatterns.Components.Factory {
	public static class FactoryProducer {
		public static AbstractFactory GetFactory(SaverType type) {
			switch (type) {
				case SaverType.Email:
					return new EmailFactory();
			
				case SaverType.Console:
					return new ConsoleFactory();
				
				case SaverType.Database:
					return new DatabaseFactory();

				default:
					return null;
			}
		}
	}
}
