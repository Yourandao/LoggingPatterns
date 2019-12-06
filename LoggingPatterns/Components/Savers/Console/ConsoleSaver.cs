using LoggingPatterns.Components.Enums;

namespace LoggingPatterns.Components.Savers.Console {
	public class ConsoleSaver : LogSaver {

        public override object Handle(object request) {
            if ((request as LogType?).IsOneOf(LogType.Debug)) {
                System.Console.WriteLine("blablabla");
            }

            return base.Handle(request);
        }
    }
}
