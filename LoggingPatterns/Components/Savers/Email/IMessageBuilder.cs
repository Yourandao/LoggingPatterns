using System.Net.Mail;

namespace LoggingPatterns.Components.Savers.Email
{
	public interface IMessageBuilder
	{
		void AddBody(string body);

		void AddRecepients(params string[] receps);

		void AddSubject(string subject);

		void AddSender(string sender);

		MailMessage GetMessage();
	}
}
