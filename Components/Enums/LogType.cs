using System;

namespace LoggingPatterns.Components.Enums {

	[Flags]
	public enum LogType {
		Error = 0x1000,
		Info = 0x0100,
		Critical = 0x0010,
		Debug = 0x0001
	}
}
