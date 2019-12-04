namespace LoggingPatterns.Components.CoR {
	public interface ILogHandler {
		ILogHandler Next(ILogHandler handler);
	}
}
