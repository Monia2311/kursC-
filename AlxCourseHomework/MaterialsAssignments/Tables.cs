using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class Tables
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 1 PAGE 23=================");

            string[] Commodity = { "notebook", "pencil", "line", "pencil sharpener" };
            double[] PriceBrutto = { 5.90, 0.84,5.50, 2.83 };

            Console.WriteLine("Welcome to our store! \n");
            Console.WriteLine("What do you want to buy? \n");
            for (int i = 0; i < Commodity.GetLength(0); i++)
            {
                Console.WriteLine($"{i + 1} {Commodity[i]}: ");
            }
            Console.WriteLine("Select a product by entering its number..........");
            var Number = int.Parse(Console.ReadLine());
            Console.WriteLine($"You have chosen the {Number} product.");
            Console.WriteLine($"{Commodity[Number-1]} costs {PriceBrutto[Number-1]} brutto and {PriceBrutto[Number-1]/1.2}");


            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 2 PAGE 23=================");

            int[,] Table = new int[3,3];
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("Identity matrix:");
            for (int i = 0; i < Table.GetLength(0); i++)
            {
                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    Table[i, j] = 1;
                    Console.Write($"{Table[i, j]} \t");
                }

                Console.WriteLine();
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 3 PAGE 23=================");

            Console.WriteLine("Enter the time spent learning C# programming in the last 5 days: (in minutes)");
            int[] Time = new int[5];
            for(int i = 0; i < Time.GetLength(0); i++)
            {
                Console.Write($"{i+1} day: ");
                Time[i] = int.Parse(Console.ReadLine());
            }
            const int More = 10;
            Console.WriteLine("Plan for next week: (in minutes)");
            for (int i = 0; i < Time.GetLength(0); i++)
            {
                Console.WriteLine($"{i + 1} day: {Time[i]+More}");
            }
        }
    }
}
