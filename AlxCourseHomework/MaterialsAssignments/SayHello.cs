using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class SayHello
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 2 PAGE 45=================");
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            if(name.Length == 0)
            {
                Console.Error.WriteLine("\n\n\t*** Błąd: nie podano imienia!\n\n");
                return;
            }

            bool women = name.ToLower()[name.Length - 1] == 'a';
            if (name == "Kuba" || name == "Barnaba")
                women = false;
            Console.WriteLine("Dzień dobry " + (women?"Pani":"Panu")+".");
        }
    }
}
