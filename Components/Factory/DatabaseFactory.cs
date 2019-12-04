﻿using LoggingPatterns.Components.Savers.Database;

namespace LoggingPatterns.Components.Factory {
	public class DatabaseFactory : AbstractFactory {
		public override ILogSaver GetLogSaver(string type) {
			if (type.ToUpper() == "POSTGRES") {
				return new PostgreSaver();
			}

			if (type.ToUpper() == "MONGO") {
				return new MongoSaver();
			}

			return null;
		}
	}
}
