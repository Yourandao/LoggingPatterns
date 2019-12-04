namespace LoggingPatterns.Components.Savers.Database {
	public class MongoSaver : ILogSaver {
		private string sConnection = "blablbalba";

		public object Save(object _object) {
			System.Console.WriteLine("Saving to postgre");
		}
	}
}
