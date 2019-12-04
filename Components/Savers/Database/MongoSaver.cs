namespace LoggingPatterns.Components.Savers.Database {
	public class MongoSaver : ILogSaver {
		private string sConnection = "blablbalba";

		public void Save(object _object) {
			System.Console.WriteLine("Saving to postgre");
		}
	}
}
