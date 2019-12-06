
using LoggingPatterns.Components.Enums;

namespace LoggingPatterns.Components.Savers.Email {
	public class FtpSaver : LogSaver {
        public override object Handle(object request) {
            if ((request as LogType?).IsOneOf(LogType.Critical)) {
                System.Console.WriteLine("ftp");
            }

            return base.Handle(request);
        }
    }
}
