using ConsoleApp1.Lessons.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lessons
{
    public class L1Constructors
    {
        public static void Test()
        {
            var spider = new Spider();
            spider.Color = "black";
            spider.Species = "Black Widow";
            spider.IsVenomous = true;
            spider.Sex = "female";

            var redSpider = new Spider("red", "tarantula", true, "male");

            var blueSpider = new Spider("blue", "Goliath");

            var yellowSpiser = new Spider("yellow", true);            
            
            //var dog = new Dog();
            //var number = 1;
            //var word = "Ala ma kota";

        }
    }
}
