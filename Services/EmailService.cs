using System.Net.Mail;
using System.Net;

namespace Library_Apı_Sysytem.Services
{
    public class EmailService
    {
        private readonly IConfiguration _configuration;
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        public void SendEmail(string toEmail, string subject, string body)
        {
            var fromEmail = _configuration.GetSection("Constants:FromEmail").Value ?? string.Empty;
            var fromEmailPassword = _configuration.GetSection("Constants:EmailAccountPassword").Value ?? string.Empty;

            var message = new MailMessage()
            {
                From = new MailAddress(fromEmail),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            message.To.Add(toEmail);

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, fromEmailPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }
    }
}

