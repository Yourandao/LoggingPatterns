using LoggingPatterns.Components.CoR;

namespace LoggingPatterns.Components.Savers.Console {
	public class ConsoleSaver : LogHandler, ILogSaver {
		public ILogHandler Next(ILogHandler handler) {

		}

		public void Save(object _object) {
			System.Console.WriteLine("Saving to console");
		}
	}
}
