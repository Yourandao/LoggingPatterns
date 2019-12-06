using LoggingPatterns.Components.Savers;

namespace LoggingPatterns.Components.Factory {
	public abstract class AbstractFactory {
		public abstract LogSaver GetLogSaver(string type);
	}
}
