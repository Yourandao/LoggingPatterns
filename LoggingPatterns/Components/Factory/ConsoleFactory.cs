using LoggingPatterns.Components.Savers;
using LoggingPatterns.Components.Savers.Console;

namespace LoggingPatterns.Components.Factory {
	public class ConsoleFactory : AbstractFactory {
		public override ILogSaver GetLogSaver(string type) {
			if (type.ToUpper() == "CONSOLE") {
				return new ConsoleSaver();
			}

			if (type.ToUpper() == "MESSAGEBOX") {
				return new MessageBoxSaver();
			}

			return null;
		}
	}
}
