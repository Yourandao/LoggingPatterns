using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace LoggingPatterns.Components.Savers.Email
{
	public class EmailSender
	{
		private readonly IMessageBuilder _builder;

		private SmtpClient _client;

		private const int SmtpPort = 465;

		private string _userEmail;
		
		public EmailSender(IMessageBuilder builder)
		{
			this._builder = builder;
		}

		public void Login(string userEmail, string password)
		{
			NetworkCredential creds = new NetworkCredential(userEmail, password);

			Regex mailRegex = new Regex(".*@(.*)");

			string mailCard = mailRegex.Match(userEmail).Groups[1].ToString();
			string host = default;

			switch (mailCard)
			{
				case "yandex.ru":
					host = "smtp.yandex.ru";
					break;

				case "mail.ru":
					host = "smtp.mail.ru";
					break;

				case "gmail.com":
					host = "smtp.gmail.com";
					break;

				default:
					throw new Exception("Not supported email service.");
			}

			this._client = new SmtpClient(host, SmtpPort);
			this._client.Credentials = creds;

			this._userEmail = userEmail;
		}

		public void Send(string body, string subject, params string[] receps)
		{
			if (this._client == null)
			{
				return;
			}

			this._builder.AddBody(body);
			this._builder.AddSender(this._userEmail);
			this._builder.AddSubject(subject);
			this._builder.AddRecepients(receps);

			try
			{
				this._client.Send(this._builder.GetMessage());
			}
			catch (Exception e)
			{
				System.Console.WriteLine(e.Message);
			}
		}
	}
}
