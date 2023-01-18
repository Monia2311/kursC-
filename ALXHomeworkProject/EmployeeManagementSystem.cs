using ALXHomeworkProject.Classes;
using System;

namespace ALXHomeworkProject
{
    public class EmployeeManagementSystem
    {
        public static void Run()
        {
            Console.WriteLine("================================================================");
            Console.WriteLine("======================EMPLOYEE MANAGEMENT SYSTEM================");
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~FIRST EMPLOYEE~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Internship internship1 = new Internship("John","Spencer");
            
            Console.WriteLine(internship1.ToString());
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~SECOND EMPLOYEE~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Employee internship2 = new Employee("Emma", "Johnson");
            Console.WriteLine(internship2.ToString());
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~SECOND EMPLOYEE - PROMOTION~~~~~~~~~~~~~~~");
            internship2 =Employee.ChangeContract(internship2);
            Console.WriteLine(internship2.ToString());
            

        }
    }
}
