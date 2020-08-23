using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace OnlineCrimeReportingSystem.Common
{
    public class MailSender
    {
        public async static Task SendEmail(string subject, string message, string recepient)
        {
            var smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential("thisisfakeid09@gmail.com", "123456789qwerty")
            };

            using (var mess = new MailMessage("thisisfakeid09@gmail.com", recepient)
            {
                Subject = subject,
                Body = message,
                IsBodyHtml = true
            })
            {
                await smtpClient.SendMailAsync(mess);
            }
        }

        public async static Task SendEmailToAdmin(string subject, string message, string email, string password)
        {
            var smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(email, password)
            };

            using (var mess = new MailMessage(email, "thisisfakeid09@gmail.com")
            {
                Subject = subject,
                Body = message,
                IsBodyHtml = true
            })
            {
                await smtpClient.SendMailAsync(mess);
            }
        }
    }
}