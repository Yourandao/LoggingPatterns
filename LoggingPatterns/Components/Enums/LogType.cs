using System;

namespace LoggingPatterns.Components.Enums {

	[Flags]
	public enum LogType {
		Error = 0x10000,
		Info = 0x01000,
		Critical = 0x00100,
		Debug = 0x00010,
        Warning = 0x00001,
		Junk = 0x00000
	}
}
