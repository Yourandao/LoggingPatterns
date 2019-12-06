using LoggingPatterns.Components.Savers;
using LoggingPatterns.Components.Savers.Email;

namespace LoggingPatterns.Components.Factory {
	public class EmailFactory : AbstractFactory {
		public override LogSaver GetLogSaver(string type) {
			if (type.ToUpper() == "EMAIL") {
				return new EmailSaver();
			}

			return null;
		}
	}
}
