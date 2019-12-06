using System;
using LoggingPatterns.Components.Enums;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LoggingPatterns.Components.Savers.Database {
	public class MongoSaver : LogSaver {
		private readonly string sConnection = "mongodb://157.230.19.140:27017";

		private readonly MongoClient _client;
		private readonly IMongoDatabase _db;

		public MongoSaver()
		{
			MongoClient client;
			this._client = new MongoClient(sConnection);
			this._db = this._client.GetDatabase("logs");
		}

        public override object Handle(object request)
        {
	        var requestType = (request as string).GetLogType();

			if (requestType.IsOneOf(LogType.Warning, LogType.Critical, LogType.Info))
			{
				IMongoCollection<BsonDocument> collection = default;

				switch (requestType)
				{
					case LogType.Warning:
						collection = this._db.GetCollection<BsonDocument>("warning");
						break;

					case LogType.Critical:
						collection = this._db.GetCollection<BsonDocument>("critical");
						break;

					case LogType.Info:
						collection = this._db.GetCollection<BsonDocument>("info");
						break;
				}

				collection?.InsertOne(new BsonDocument()
				{
					{ "Date", DateTime.Now.ToString() },
					{ "Log", request.ToString() }
				});

				System.Console.WriteLine("Successfully pushed into mongodb");
			}

            return base.Handle(request);
        }
    }
}
