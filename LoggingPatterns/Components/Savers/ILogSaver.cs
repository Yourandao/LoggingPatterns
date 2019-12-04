using LoggingPatterns.Components.CoR;

namespace LoggingPatterns.Components.Savers {
	public interface ILogSaver : ILogHandler {
		object Save(object _object);
	}
}
