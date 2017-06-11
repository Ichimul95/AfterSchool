using System;
using System.Net;
using System.Net.Mail;

namespace MyAfterSchool.Services
{
    public class EmailService
    {
        private readonly Configuration _config;
        private readonly  string toEmailAdress="ichimvlad95@gmail.com";
        public EmailService()
        {
            _config = Configuration.GetConfiguration();
        }

        public void SendContact(string name, string subject,string email, string phone, string message)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("The first name field cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("The e-mail field cannot be empty.");
            }

            MailMessage mail = new MailMessage();
            mail.To.Add(toEmailAdress);

            mail.From = new MailAddress(email);
            mail.Subject = "Mesaj de la " + name;
            mail.Body = message + "\nPhone number: " + phone;

            using (var smtp = new SmtpClient())
            {
                smtp.Credentials = new NetworkCredential()
                {
                    UserName = _config.Username,
                    Password = _config.Password
                };
                smtp.Host = _config.Host;
                smtp.Port = _config.Port;
                smtp.EnableSsl = _config.IsSslEnabled;
                smtp.Send(mail);
            }
        }
    }
}