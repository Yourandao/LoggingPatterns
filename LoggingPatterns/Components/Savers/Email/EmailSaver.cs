namespace LoggingPatterns.Components.Savers.Email {
	public class EmailSaver : ILogSaver {
		public object Save(object _object) {
			System.Console.WriteLine("Saving to recepient's mail");
		}
	}
}
