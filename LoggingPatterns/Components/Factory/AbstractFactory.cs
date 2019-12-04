using LoggingPatterns.Components.Savers;

namespace LoggingPatterns.Components.Factory {
	public abstract class AbstractFactory {
		public abstract ILogSaver GetLogSaver(string type);
	}
}
