using LoggingPatterns.Components.Enums;
using System.Windows.Forms;

namespace LoggingPatterns.Components.Savers.Console {
	public class MessageBoxSaver : LogSaver {
		public override object Handle(object request) {
			var requestType = (request as string).GetLogType();

			if (requestType.IsOneOf(LogType.Debug)) {
	            MessageBox.Show(request as string);
            }

            return base.Handle(request);
        }
    }
}
