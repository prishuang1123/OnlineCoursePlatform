using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

//寄送註冊驗證信
namespace UseASPNETCoreIdentity
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var mail = new MailMessage();
            mail.From = new MailAddress("z20000624@gmail.com");
            mail.To.Add(email);
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = htmlMessage;

            SmtpClient client = new SmtpClient("smtp.gmail.com",587);
            //SmtpClient client = new SmtpClient("smtp.live.com");
            //client.Port = 587;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("z20000624@gmail.com", "brucrnnlorbhoxcu");
            client.EnableSsl = true;
            client.Send(mail);
        }
    }
}
