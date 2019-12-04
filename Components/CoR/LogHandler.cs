namespace LoggingPatterns.Components.CoR {
	public class LogHandler : ILogHandler {
		private ILogHandler _next = default;

		public ILogHandler Next(ILogHandler handler) {
			this._next = handler;

			return handler;
		}
	}
}
