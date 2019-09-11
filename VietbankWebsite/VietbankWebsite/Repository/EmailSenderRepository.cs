using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Text;
using VietbankWebsite.Models;

namespace VietbankWebsite.Repository
{
    public class EmailSenderRepository: IEmailSenderRepository
    {
        private readonly EmailSender _emailSender;
        public EmailSenderRepository(IOptions<EmailSender> emailSender)
        {
            _emailSender = emailSender.Value;
        }

        public void SendMail(string toAddresses, string subject, string body)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress($"{_emailSender.MailFrom}@vietbank.com.vn");
                mail.To.Add(toAddresses);
                mail.Subject = subject;
                mail.SubjectEncoding = Encoding.UTF8;
                mail.Body = body;
                mail.BodyEncoding = Encoding.UTF8;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient(_emailSender.DomainMail, _emailSender.PortMail))
                {
                    smtp.Credentials = new NetworkCredential(_emailSender.MailFrom, _emailSender.PassMailFrom);
                    smtp.Send(mail);
                }
            }
        }
    }

    public interface IEmailSenderRepository
    {
        void SendMail(string toAddresses, string subject, string body);
    }
}
