
using LoggingPatterns.Components.Enums;

namespace LoggingPatterns.Components.Savers.Console {
	public class MessageBoxSaver : LogSaver {

        public override object Handle(object request) {
            if ((request as LogType?).IsOneOf(LogType.Debug)) {
                System.Console.WriteLine("messagebox");
            }

            return base.Handle(request);
        }
    }
}
