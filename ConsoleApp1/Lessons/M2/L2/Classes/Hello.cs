using ConsoleApp1.Lessons.M2.L2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lessons.M2.L2.Classes
{
    public class Hello : IHello
    {
        public void SayGoodMorning()
        {
            Console.WriteLine("Good Morning!");
        }

        public void SayGoodMorning(string name)
        {
            Console.WriteLine($"Good Morning {name}!");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}
