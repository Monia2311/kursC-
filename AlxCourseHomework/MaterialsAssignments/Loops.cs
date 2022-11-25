using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class Loops
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 1 PAGE 21=================");

            double[,] Table = new double[,] { { 1, 3.58, 5, 10, 2}, { 2, 9.61, 5, 25, 5}, { 3, 8.52, 8, 18, 3}, { 4, 10.25, 8, 36, 6}, { 5, 6.17, 23, 4, 1 } };

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("id  c_netto    VAT  ilość sztuk  ilość pudeł");
            for (int i=0; i < Table.GetLength(0); i++)
            {
                for (int j=0; j < Table.GetLength(1); j++)
                {
                    Console.Write($"{Table[i, j]} \t");
                }

                Console.WriteLine();
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            for (int i = 0; i < Table.GetLength(0); i++)
            {
                Console.Write($"{Table[i, 0]} \t price brutto = {Table[i, 1] + Table[i, 1] * Table[i,2]*0.01}");

                Console.WriteLine();
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            for (int i = 0; i < Table.GetLength(0); i++)
            {
                Console.Write($"{Table[i, 0]} \t value of the goods = {(Table[i, 1] + Table[i, 1] * Table[i, 2] * 0.01) * Table[i, 3] * Table[i,4]}");

                Console.WriteLine();
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            for (int i = 0; i < Table.GetLength(0); i++)
            {
                Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine($"TAG goods number: {Table[i, 0]}\t");
                Console.WriteLine($"\t Price netto: {Table[i,1]}");
                Console.WriteLine($"\t VAT: {Table[i, 2]} %");
                Console.WriteLine($"\t Price brutto: {Table[i, 1] + Table[i, 1] * Table[i, 2] * 0.01}");
                Console.WriteLine($"\t Price per box: {(Table[i, 1] + Table[i, 1] * Table[i, 2] * 0.01) * Table[i,3]}");
                Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 2 PAGE 21=================");

            Console.WriteLine("The program will determine the divisors of the number given by the user.");
            Console.WriteLine("Enter a number: ");
            var Liczba=Double.Parse(Console.ReadLine());
            Console.WriteLine("The divisors given by numbers are: ");
            for (int i = 0; i <= Liczba; i++)
            {
                if(Liczba%i == 0)
                    Console.Write($"{i} \t ");
              
            }

        }
    }
}
