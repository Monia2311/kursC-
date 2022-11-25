using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments.M2.L1
{
    public class SeniorityServiceTest
    {
        public static void Run()
        {
            var seniorityService = new SeniorityService();

            var employee1 = new Employee();
            employee1.Name = "Anna";
            employee1.Salary = 25000;
            employee1.Experience = 9;
            var employee2 = new Employee();
            employee2.Name = "Bartek";
            employee2.Salary = 13000;
            employee2.Experience = 21;
            var employee3 = new Employee();
            employee3.Name = "Zuzia";
            employee3.Salary = 100;
            employee3.Experience = 17;
            seniorityService.ClassifySeniorityByExperience(employee1);
            seniorityService.ClassifySeniorityByExperience(employee2);
            seniorityService.ClassifySeniorityByExperience(employee3);
            Console.WriteLine("Classify Seniority By Experience: ");
            Console.WriteLine("Juniors: ");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids: ");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors: ");
            PresentEmployees(seniorityService.SeniorEmployees);
            seniorityService.ClearClassifyLists();
            seniorityService.ClassifySeniorityBySalary(employee1);
            seniorityService.ClassifySeniorityBySalary(employee2);
            seniorityService.ClassifySeniorityBySalary(employee3);
            Console.WriteLine("Classify Seniority By Salary: ");
            Console.WriteLine("Juniors: ");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids: ");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors: ");
            PresentEmployees(seniorityService.SeniorEmployees);


        }
        public static void PresentEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee: {employee.Name}");
            }
        }
    }
}
