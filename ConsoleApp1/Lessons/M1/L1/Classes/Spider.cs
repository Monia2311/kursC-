﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lessons.M1.L1.Classes
{
    public class Spider
    {
        public string Color;
        public string Species;
        public bool IsVenomous;
        public string Sex;

        public Spider() { }

        public Spider(string color, string species)
        {
            Color = color;
            Species = species;
            IsVenomous = true;
            Sex = "male";
        }

        public Spider(string color, bool isVenomous)
            {
                Color=color;
                IsVenomous=isVenomous;
            }
        public Spider(string color,string species, bool isVenomous, string sex) //konstruktor
        {
            Color = color;
            Species = species;
            IsVenomous = isVenomous;
            Sex=sex;

        }

        public void Present ()
        {
            Console.WriteLine($"Here is a new spider");
            Console.WriteLine($"Spacies: {Species}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Sex: {Sex}");
        }
    }
}