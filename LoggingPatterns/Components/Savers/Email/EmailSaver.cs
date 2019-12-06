
using LoggingPatterns.Components.Enums;

namespace LoggingPatterns.Components.Savers.Email {
	public class EmailSaver : LogSaver {
        public override object Handle(object request) {
            if ((request as LogType?).IsOneOf(LogType.Critical)) {
                EmailSender sender = new EmailSender(new EmailBuilder());

				sender.Login("thisisemail@yandex.ru", "asdfasdfasdf");
				sender.Send(request as string, "CRITICAL", "vasyapupkin@gmail.com", "kolyavaskin@mail.ru");
            }

            return base.Handle(request);
        }
    }
}
