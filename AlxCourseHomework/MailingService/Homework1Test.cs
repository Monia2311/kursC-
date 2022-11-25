using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MailingService
{
    public class Homework1Test
    {
        public static void Run()
        {
            Console.WriteLine("New email....................");
            Console.WriteLine();
            Console.Write("From:");
            var from=Console.ReadLine();
            Console.Write("To: ");
            var to=Console.ReadLine();
            Console.Write("Subject: ");
            var subject=Console.ReadLine();
            Console.Write("Message: ");
            var message=Console.ReadLine();

            var email1 = new Email();
            email1.From = "Anna";
            email1.To = "Zbyszek";
            email1.Subject = "Zakupy";
            email1.Message = "Koszt zakupu 200.00 PLN";
            EmailService.SendEmail(email1.From,email1.To,email1.Subject,email1.Message);

            var email2 = new Email();
            email2.From = "Szymon";
            email2.To = "Mateusz";
            email2.Subject = "Mecz";
            email2.Message = "Mecz o 16:00";
            EmailService.SendEmail(email2.From,email2.To,email2.Subject,email2.Message);

            var email3 = new Email();
            email3.From = "Karolina";
            email3.To = "Zuzia";
            email3.Subject = "Kawiarnia";
            email3.Message = "Spotkanie jutro o 14:00";
            EmailService.SendEmail(email3.From, email3.To, email3.Subject, email3.Message);

            var email4 = new Email();
            email4.From = "Vet";
            email4.To = "Client1";
            email4.Subject = "Szcepienie puupils";
            email4.Message = "Zapraszam jutro o 8:30";
            EmailService.SendEmail(email4.From, email4.To, email4.Subject, email4.Message);

            var email5 = new Email();
            email5.From = "Hotel";
            email5.To = "Client2";
            email5.Subject = "Potwierdzenie rezerwacji";
            email5.Message = "Dokonano rezerwacji na 11.11 - 13.11. zapraszamy";
            EmailService.SendEmail(email4.From, email4.To, email4.Subject, email4.Message);
        }
    }
}
