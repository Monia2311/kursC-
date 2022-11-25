using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Lessons.M2.L2.Classes
{
    public class TaxService
    {
        private const double VatPercentage = 0.23;
        private const double GovermentPercentage = 0.17;
        public double CalculateTax (double income)
        {
            //var tax = 0.0;
            var vatTax = CalculateVat(income);
            var govermentTax = CalculateGovermentTax(income,vatTax);
            return vatTax+govermentTax;
        }
        
        private double CalculateVat(double income)
        {
            return income*VatPercentage;
        }

        private double CalculateGovermentTax(double income, double vatTax)
        {
            return (income - vatTax) * GovermentPercentage;
        }
    }
}
