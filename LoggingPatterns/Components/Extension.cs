using System.Linq;
using LoggingPatterns.Components.Enums;

namespace LoggingPatterns.Components
{
	public static class Extension {
		public static bool IsOneOf<T>(this T self, params T[] cases) {
			return cases.Contains(self);
		}

		public static LogType GetLogType(this string log)
		{
			if (log.ToUpper().Contains("INFO")) return LogType.Info;

			if (log.ToUpper().Contains("CRIT")) return LogType.Critical;

			if(log.ToUpper().Contains("DEBUG")) return LogType.Debug;

			if (log.ToUpper().Contains("ERR")) return LogType.Error;

			if (log.ToUpper().Contains("WARN")) return LogType.Warning;

			return LogType.Junk;
		}
	}
}