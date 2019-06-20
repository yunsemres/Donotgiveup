using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    public class DenemeMail
    {
        public void Mail(string sendMailAdress, string subject, string body)
        {
            SmtpClient client = new SmtpClient();
            MailAddress from = new MailAddress("mailadresi@gmail.com");
            MailAddress to = new MailAddress("denemeonay1@hotmail.com");//bizim mail adresi
            MailMessage msg = new MailMessage(from, to);
            msg.IsBodyHtml = true;
            msg.Subject = subject;
            msg.Body += " Gönderen Mail Adresi " + to + " | <h1> " + body + " </h1>"; 
            msg.CC.Add(sendMailAdress);
            NetworkCredential info = new NetworkCredential("denemeonay1@hotmail.com", "112233445566y");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = info;
            client.Send(msg);
        }
    }
}
