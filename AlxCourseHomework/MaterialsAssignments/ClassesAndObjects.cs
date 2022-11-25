using AlxCourseHomework.MaterialsAssignments.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class ClassesAndObjects
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("=============EXERCISE NUMBER 1 PAGE 45=================");
            Car car1 = new Car();
            car1.CarBrand = "Ferrari";
            car1.PriceNetto = 1198560;
            car1.ReversingCamera = 1499;
            car1.CruiseControl = 599;
            car1.DogCover = 499;
            car1.Vat = 27;
            car1.PresentCar();
            Car car2 = new Car();
            car2.CarBrand = "Toyota";
            car2.PriceNetto = 65400;
            car2.ReversingCamera = 899;
            car2.CruiseControl = 499;
            car2.DogCover = 499;
            car2.Vat = 27;
            car2.PresentCar();
            Car car3 = new Car();
            car3.CarBrand = "Mercedes";
            car3.PriceNetto = 89900;
            car3.ReversingCamera = 599;
            car3.CruiseControl = 789;
            car3.DogCover = 499;
            car3.Vat = 27;
            car3.PresentCar();
        }
    }
}
