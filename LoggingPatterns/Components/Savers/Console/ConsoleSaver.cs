using LoggingPatterns.Components.CoR;
using LoggingPatterns.Components.Enums;

namespace LoggingPatterns.Components.Savers.Console {
	public class ConsoleSaver : LogHandler, ILogSaver {
		public object Save(object _object) {
			if ((_object as LogType?).IsOneOf(LogType.Critical, LogType.Debug, LogType.Error)) {
				System.Console.WriteLine("blablabla");
			}

			return null;
		}
	}
}
