using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerCallbackDemo
{
    class Program
    {
        static void PrintTime(object state)
        {
            Console.WriteLine($"Time is: {DateTime.Now}, Param is: {state.ToString()}");
        }

        static void SendEmail(object state)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("nguyenhongphat28121998@gmail.com");
                message.To.Add(new MailAddress("nhatlmse62793@fpt.edu.vn"));
                message.Subject = "Test";
                message.Body = state.ToString();

                Console.WriteLine("Mail sending to " + message.To);

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("nguyenhongphat28121998@gmail.com", "ilovegermany");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                Console.WriteLine("Mail sended to " + message.To);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void Main(string[] args)
        {
            TimerCallback timeCB = new TimerCallback(SendEmail);
            Timer timer = new Timer(timeCB, "Hello", 0, 1000);
            Console.WriteLine("Hit enter to terminate...");
            Console.ReadLine();
        }
    }
}
