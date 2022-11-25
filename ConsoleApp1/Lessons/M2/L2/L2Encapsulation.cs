using ConsoleApp1.Lessons.M2.L2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lessons.M2.L2
{
    public class L2Encapsulation
    {
        public static void Run()
        {
            var taxService = new TaxService();
            var income = 5000;
            var tax = taxService.CalculateTax(income);
            Prsesnt(tax,income);
        }

        private static void Prsesnt (double tax, double income)
        {
            Console.WriteLine($"Income: {income}");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Netto: {income - tax}");
        }
    }
}
