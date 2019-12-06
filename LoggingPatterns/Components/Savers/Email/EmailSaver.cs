
using LoggingPatterns.Components.Enums;

namespace LoggingPatterns.Components.Savers.Email {
	public class EmailSaver : LogSaver {
        public override object Handle(object request) {
            if ((request as LogType?).IsOneOf(LogType.Critical)) {
                System.Console.WriteLine("email");
            }

            return base.Handle(request);
        }
    }
}
