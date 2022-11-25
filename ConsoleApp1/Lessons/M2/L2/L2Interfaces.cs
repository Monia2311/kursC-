using ConsoleApp1.Lessons.M2.L2.Classes;
using ConsoleApp1.Lessons.M2.L2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lessons.M2.L2
{
    public class L2Interfaces
    {
        public static void Run()
        {
            IHello helloService = new PolishHello();
            helloService.SayHello();
            helloService.SayGoodMorning();
            helloService.SayGoodMorning("Monika");
            helloService.SayHello("Monika");

            IHello helloService1 = new Hello();
            helloService1.SayHello();
            helloService1.SayGoodMorning();
            helloService1.SayGoodMorning("Monika");
            helloService1.SayHello("Monika");
        }
    }
}
