using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lessons.M2.L1
{
    public class L1Loops
    {
        public static void Run()
        {
            List<string> names = new List<string>();
            names.Add("Adrian");
            names.Add("Mateusz");
            names.Add("Monika");
            names.Add("Magda");
            names.Add("Andrzej");

            foreach (string name in names)
            {
                //name.ToLower(); nic nie zmieniło
                Console.WriteLine(name + " kursant.");
                Console.WriteLine(name.ToLower() + " kursant.");
                Console.WriteLine(name);
            }
        }

        public static void RunFor()
        {
            int[] numbers = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i += 2)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] % 2;
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        public static void RunWhile()
        {
            //char c='q';
            Console.WriteLine("Run While: ");
            var c = Console.ReadKey().KeyChar;
            while (c != 'n')
            { 
                Console.WriteLine();
                Console.WriteLine("still in the loop!");
                Console.WriteLine("Write a character: ");
                c=Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.WriteLine("Outside the loop.");

            /*string numberFromKeyboard="0";
            while(Int32.Parse(numberFromKeyboard)<100000)
            {
                Console.WriteLine("still in the loop!");
                Console.WriteLine("Write a character: ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.WriteLine("Outside the loop.");*/
        }

        public static void RunDoWhile()
        {
            //char c = 'q';
            Console.WriteLine("Run Do While: ");
            var c = Console.ReadKey().KeyChar;
            do
            {
                Console.WriteLine();
                Console.WriteLine("still in the loop!");
                Console.WriteLine("Write a character: ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (c != 'n');
            Console.WriteLine("Outside the loop.");

        }
    }
}
