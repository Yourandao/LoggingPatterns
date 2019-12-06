using System.Net.Mail;

namespace LoggingPatterns.Components.Savers.Email
{
	public class EmailBuilder : IMessageBuilder
 	{
		private MailMessage _message = new MailMessage();

		public EmailBuilder()
		{
			this.Reset();
		}

		private void Reset()
		{
			this._message = new MailMessage();
		}

		public void AddBody(string body)
		{
			this._message.Body = body;
		}

		public void AddRecepients(params string[] receps)
		{
			for (int i = 0; i < receps.Length; i++)
			{
				this._message.Bcc.Add(receps[i]);
			}
		}

		public void AddSubject(string subject)
		{
			this._message.Subject = subject;
		}

		public void AddSender(string sender)
		{
			this._message.From = new MailAddress(sender);
		}

		public MailMessage GetMessage()
		{
			MailMessage tMessage = this._message;

			this.Reset();

			return tMessage;
		}
    }
}
