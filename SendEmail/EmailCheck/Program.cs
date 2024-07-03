using System;
using System.Net;
using System.Net.Mail;

class Program
{
    static void Main()
    {
        MailMessage eposta = new MailMessage();

        void MailGonder()
        {
            try
            {
                eposta.From = new MailAddress("senderadress@outlook.com");
                eposta.To.Add("receiveradress@gmail.com");
                eposta.Subject = "the subject";
                eposta.Body = "the whole message";

                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.office365.com",
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("senderadress@outlook.com", "password"),
                };

                smtp.Send(eposta);
                Console.WriteLine("The Mail has sent successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        MailGonder();
    }
}
