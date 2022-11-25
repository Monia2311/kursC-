using ConsoleApp1.Lessons.M2.L2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lessons.M2.L2
{
    public class L2GettersAndSetters
    {
        public static void Run()
        {
            var computer = new Computer(); //tworzymy obiekt z klasy Computer
            computer.Brand = "Dell";
            computer.ProcesorFrequency = 3.2;
            computer.NumbersOfCores = 3;
            computer.Name = "My Pc";
            Console.WriteLine();
            PresentComputer(computer);

            Console.WriteLine("\n");
            var computer1=new Computer();
            computer1.Brand = "Dell";
            computer1.ProcesorFrequency = 10;
            computer1.NumbersOfCores = 4;
            computer1.Name = "My Pc";
            Console.WriteLine();
            PresentComputer(computer1);
        }
        private static void PresentComputer(Computer computer)
        { 
            Console.WriteLine($"Name: {computer.Name}");
            Console.WriteLine($"Procesor Frequency: {computer.ProcesorFrequency}");
            Console.WriteLine($"Namber Of Cares: {computer.NumbersOfCores}");
            Console.WriteLine($"Brand: {computer.Brand}");
        }
    }
}
