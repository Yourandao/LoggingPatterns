﻿using LoggingPatterns.Components.Savers.Email;

namespace LoggingPatterns.Components.Factory {
	public class EmailFactory : AbstractFactory {
		public override ILogSaver GetLogSaver(string type) {
			if (type.ToUpper() == "EMAIL") {
				return new EmailSaver();
			}

			if (type.ToUpper() == "FTP") {
				return new FtpSaver();
			}

			return null;
		}
	}
}