using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class ConditionalStatements
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 1 PAGE 19=================");

            double price;
            Console.WriteLine("Enter the cost of purchases: ");
            price = Double.Parse(Console.ReadLine());
            Console.WriteLine($"The cost of purchases: {price}");

            if (price > 100)
            {
                Console.WriteLine("A discount of 15 percent was applied");
                price *= 0.85;
            }
            else if (price > 60 && price < 100)
            {
                Console.WriteLine("A discount of 5 percent was applied");
                price *= 0.95;
            }
            else
            {
                Console.WriteLine("No discount applied");
                price *= 1;
            }
            Console.WriteLine($"The cost of shopping after the discount is: {price}");
            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 2 PAGE 19=================");

            double price2;
            Console.WriteLine("Enter the cost of purchases: ");
            price2 = Double.Parse(Console.ReadLine());
            Console.WriteLine($"The cost of purchases: {price2}");

            switch (price2)
            {
                case > 100:
                    Console.WriteLine("A discount of 15 percent was applied");
                    price2 *= 0.85;
                    break;

                case < 60:
                    Console.WriteLine("No discount applied");
                    price2 *= 1;
                    break;

                default:
                    Console.WriteLine("A discount of 5 percent was applied");
                    price2 *= 0.95;
                    break;

            }

            Console.WriteLine($"The cost of shopping after the discount is: {price2}");
            Console.WriteLine();
        }
    }
}
