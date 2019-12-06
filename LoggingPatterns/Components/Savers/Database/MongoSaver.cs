
using LoggingPatterns.Components.Enums;

namespace LoggingPatterns.Components.Savers.Database {
	public class MongoSaver : LogSaver {
		private string sConnection = "blablbalba";

        public override object Handle(object request) {
            if ((request as LogType?).IsOneOf(LogType.Warning, LogType.Critical, LogType.Info)) {
                System.Console.WriteLine("mongo");
            }

            return base.Handle(request);
        }
    }
}
