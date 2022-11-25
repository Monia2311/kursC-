using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lessons.M2.L2.Classes
{
    public class Computer
    {
        private string _brand;
        private double? _procesorFrequency;
        public string Brand
        {
            get
            {
                Console.WriteLine("Getting computer brand.");
                return _brand;
            }
            set
            {
                Console.WriteLine($"Setting computer brand as {value}");
                _brand = value;
            }
        }
    
        public string Name { get; set; }

        public double? ProcesorFrequency 
        { 
            get 
            {
                Console.WriteLine("Getting processor clock frequency [GHz]... ");
                return (_procesorFrequency);    
            } 
            set 
            {
                if (value > 0 && value < 4)
                {
                    Console.WriteLine($"Setting computer's processor clock frequency as {value} [ghz].");
                    _procesorFrequency = value;
                }
                    
                else
                {
                    _procesorFrequency = null;
                    Console.WriteLine("Invalid processor frequency value!");
                }
                    
            } 
        }

        public int NumbersOfCores { get; set; }

        public string Model;

        public int StorageSpace { get; } //definiujemy tylko w konstruktorze
        public readonly string GraphicalCarModel; //property, które definiujemy tylko w konstruktorze
    }
}
