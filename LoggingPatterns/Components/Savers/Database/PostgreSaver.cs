using LoggingPatterns.Components.Enums;
using Npgsql;

namespace LoggingPatterns.Components.Savers.Database {
    public class PostgreSaver : LogSaver {
        private string sConnection = "Server = 157.230.19.140; User Id = api; Password = apiapiapi; Database = logs";

        private NpgsqlConnection _connection;

        public PostgreSaver()
        {
			this._connection = new NpgsqlConnection(this.sConnection);
			this._connection.Open();
        }

		public override object Handle(object request)
		{
			var requestType = (request as string).GetLogType();

            if (requestType.IsOneOf(LogType.Info, LogType.Warning, LogType.Critical)) {
                NpgsqlCommand command =
	                new NpgsqlCommand($"select * from insert_log('{requestType.ToString().ToLower()}', '{request}')",
		                this._connection);

                command.ExecuteNonQuery();

				System.Console.WriteLine("Successfully pushed to postgres");

				this._connection.Close();
            }

            return base.Handle(request);
        }
    }
}
