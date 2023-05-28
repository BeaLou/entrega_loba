using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Service.Util
{
    public class SendEmailUtil
    {
        public async void SendEmail(Email emailConfigurations, string path) 
        {
            var fixedPath = @"D:\dev\API.Loba\Loba.Application\";
            string totalPath = fixedPath + path;

            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress(emailConfigurations.from, emailConfigurations.fromAlias);
            message.To.Add(new MailAddress(emailConfigurations.to));
            message.Subject = emailConfigurations.subject;

            Attachment attachment = new Attachment(totalPath, MediaTypeNames.Application.Octet);
            message.Attachments.Add(attachment);

            message.IsBodyHtml = false;
            message.Body = emailConfigurations.body;
            smtp.Port = emailConfigurations.port;
            smtp.Host = emailConfigurations.host;
            smtp.EnableSsl = emailConfigurations.ssl;
            smtp.UseDefaultCredentials = emailConfigurations.usedefaultcredentials;
            smtp.Credentials = new NetworkCredential(emailConfigurations.credentialEmail, emailConfigurations.credentialPassword);
            smtp.DeliveryMethod = emailConfigurations.deliverymethod;
            await smtp.SendMailAsync(message);
        }

    }
}
