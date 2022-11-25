using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments.M2.L1
{
    public class SeniorityService
    {
        public List<Employee> JuniorEmployees;
        public List<Employee> MidEmployees;
        public List<Employee> SeniorEmployees;

        public SeniorityService()
        {
            JuniorEmployees = new List<Employee>();
            MidEmployees = new List<Employee>();
            SeniorEmployees = new List<Employee>();
        }

        public void ClassifySeniorityBySalary(Employee employee)
        {
            if (employee.Salary < 1000)
            {
                JuniorEmployees.Add(employee);
            }
            else if (employee.Salary >= 1000 && employee.Salary <= 20000)
            {
                MidEmployees.Add(employee);
            }
            else
            {
                SeniorEmployees.Add(employee);
            }
        }

        public void ClassifySeniorityByExperience(Employee employee)
        {
            if (employee.Experience < 10)
            {
                JuniorEmployees.Add(employee);
            }
            else if (employee.Experience >= 10 && employee.Experience <= 20)
            {
                MidEmployees.Add(employee);
            }
            else
            {
                SeniorEmployees.Add(employee);
            }
        }

        public void ClearClassifyLists()
        {
            MidEmployees.Clear();
            SeniorEmployees.Clear();
            JuniorEmployees.Clear();
        }
    }
}
