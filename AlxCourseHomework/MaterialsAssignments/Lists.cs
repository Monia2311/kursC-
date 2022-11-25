using AlxCourseHomework.MaterialsAssignments.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class Lists
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 1 PAGE 25=================");
            foreach (var p in Enum.GetValues(typeof(Months)))
                Console.WriteLine(p.ToString());

            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 2 PAGE 25=================");
            List<string> MounthsList = new List<string>();
            MounthsList.Add("January");
            MounthsList.Add("February");
            MounthsList.Add("March");
            MounthsList.Add("April");
            MounthsList.Add("May");
            MounthsList.Add("June");
            MounthsList.Add("Juy");
            MounthsList.Add("August");
            MounthsList.Add("September");
            MounthsList.Add("October");
            MounthsList.Add("November");
            MounthsList.Add("December");

            ShowList(MounthsList);
        }

        public static void ShowList(List<string> list)
        {
            Console.WriteLine($"Number of elements: {list.Count}");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
