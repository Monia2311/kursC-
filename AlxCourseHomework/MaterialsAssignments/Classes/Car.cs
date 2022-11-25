using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialsAssignments.Classes
{
    public class Car
    {
        public string CarBrand;
        public double PriceNetto;
        public double ReversingCamera;//kamera cofania
        public double CruiseControl;//tempomat
        public double DogCover;//pokroweic dla psa na siedzenie
        public int Vat;

        public void PresentCar()
        {
            Console.WriteLine("''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine($"Car Brand {CarBrand}");
            Console.WriteLine($"Price Netto: {PriceNetto}");
            Console.WriteLine($"ReversingCamera {ReversingCamera}");
            Console.WriteLine($"Cruise control: {CruiseControl}");
            Console.WriteLine($"Dog cover {DogCover}");
            Console.WriteLine("''''''''''''''''''''''''''''''''''''''''''''");
        }
    }

}
