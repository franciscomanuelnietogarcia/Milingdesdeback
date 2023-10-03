using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Milingdesdeback
{
    public class logic
    {
        public string sendMail( string to, string asunto, string body)
        {
            string msge = "Error al enviar este correo. Por favor verifique los datos o intentelo más tarde";
            string from = "pruebaparamailing80@gmail.com";
            string displayName = "Developer";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(to);

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.office365.com");
                client.Credentials = new NetworkCredential(from, "tuContraseña");
                client.EnableSsl = true;
            }
            catch (Exception ex)
            {
                msge = ex.Message + ".Por favor verifica tu conexión a internet y que tus datos seas correctos e intenta nuevamente.";
            }
            return msge;
        }
    }
}
