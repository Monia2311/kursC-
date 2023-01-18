using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXHomeworkProject.Classes
{
    public class Internship : Employee, InterfaceEmployee
    {
        const double rate = 1000;
        

        public Internship(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Internship(string name, string surname,double paySalary, TypeOfContractEnum typeOfContractEnum=TypeOfContractEnum.INTERNSHIP) :base(name,surname,paySalary, typeOfContractEnum)
        {
            Name = name;
            Surname = surname;
            TypeOfContract=typeOfContractEnum;
            Rate = rate;
            PaySalary = paySalary;
        }

        public double Salary()
        {
            PaySalary = Rate;
            return PaySalary;
        }
    }
}
