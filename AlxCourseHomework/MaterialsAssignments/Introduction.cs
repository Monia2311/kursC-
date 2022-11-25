using AlxCourseHomework.MaterialsAssignments.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class Introduction
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 1 PAGE 12=================");
            string Name = "Monika";
            string Surname = "Danych";
            int Age = 37;
            float Height = 1.67f;
            char Sex = 'K'; //znak w apostrofach
            string Pesel = "1234567890";

            Console.WriteLine("My name is: " + Name);
            Console.WriteLine($"My surname is: {Surname}");
            Console.WriteLine($"I am {Age} years old");
            Console.WriteLine($"I am {Height} meters tall");
            Console.WriteLine("My gender: " + Sex );
            Console.WriteLine($"My PESEL: {Pesel}");
            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 2 PAGE 12=================");
            int Height2 = (int)Height;

            Console.WriteLine("My name is: " + Name);
            Console.WriteLine($"My surname is: {Surname}");
            Console.WriteLine($"I am {Age} years old");
            Console.WriteLine($"I am {Height2} meters tall");
            Console.WriteLine("My gender: " + Sex);
            Console.WriteLine($"My PESEL: {Pesel}");
            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 3 PAGE 12=================");
            Months Month = Months.NOVEMBER;
            DaysOfTheWeek Day = (DaysOfTheWeek)1;
            Console.WriteLine($"Today is: {Month}");
            Console.WriteLine($"Day of the week: {Day}");
        }

    }
}
