using System;


namespace ALXHomeworkProject.Classes
{
    public class Fulltime : Employee, InterfaceEmployee
    {
        const int rate = 5000;
        
        public Fulltime(string name, string surname, TypeOfContractEnum typeOfContractEnum=TypeOfContractEnum.FULLTIME):base()
        {
            Name = name;
            Surname = surname;
            TypeOfContract=typeOfContractEnum;
            Rate = rate;
        }

        public int HowMutchOvertime()
        {
            Console.WriteLine("Enter the number of overtime hours: ");
            Overtime = Int32.Parse(Console.ReadLine());
            return Overtime;
        }

        public double Salary()
        {
            PaySalary = Rate+Overtime*(Rate/60);
            return PaySalary;
        }
    }
}
