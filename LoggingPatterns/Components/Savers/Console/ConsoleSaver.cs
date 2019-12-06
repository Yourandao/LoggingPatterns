using LoggingPatterns.Components.Enums;

namespace LoggingPatterns.Components.Savers.Console {
	public class ConsoleSaver : LogSaver {

        public override object Handle(object request)
        {
	        var requestType = (request as string).GetLogType();

            if (requestType.IsOneOf(LogType.Debug)) {
	            System.Console.WriteLine(request.ToString());
            }

            return base.Handle(request);
        }
    }
}
