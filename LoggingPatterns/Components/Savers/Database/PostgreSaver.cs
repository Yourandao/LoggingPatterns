using LoggingPatterns.Components.Enums;

namespace LoggingPatterns.Components.Savers.Database {
    public class PostgreSaver : LogSaver {
        private string sConnection = "blablbalba";

        public override object Handle(object request) {
            if ((request as LogType?).IsOneOf(LogType.Info, LogType.Warning, LogType.Critical)) {
                System.Console.WriteLine("postgres");
            }

            return base.Handle(request);
        }
    }
}
