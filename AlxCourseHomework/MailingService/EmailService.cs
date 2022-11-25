using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MailingService
{
    public class EmailService
    {
        public static void SendEmail(string From,string To, string Subject, string Message)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("The email has been sent ");
            Console.WriteLine($"From:  {From}");
            Console.WriteLine($"To:  {To}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Message:  {Message}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
