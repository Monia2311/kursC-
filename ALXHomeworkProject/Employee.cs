using ALXHomeworkProject.Classes;
using System;


namespace ALXHomeworkProject
{
    public class Employee:InterfaceEmployee
    {
        public string Name;
        public string Surname;
        public int Overtime;
        public double PaySalary;
        public double Rate;
        public TypeOfContractEnum TypeOfContract; //public TypeOfContractEnum? TypeOfContract - ze znakiem zapytania bez domyślnego kontraktu
        //domyślny kontrakt pierwszy z listy - stażysta

        public Employee() //konstruktor domyślny
        {

        }
        public Employee(string name, string surname, double paySalary=0, TypeOfContractEnum typeOfContractEnum = TypeOfContractEnum.INTERNSHIP)
        {
            Name = name;
            Surname = surname;
            TypeOfContract=typeOfContractEnum;
            PaySalary = paySalary;
        }

       public static Employee ChangeContract(Employee employee)
        {
            if (employee.TypeOfContract == TypeOfContractEnum.INTERNSHIP)
                //employee.TypeOfContract= TypeOfContractEnum.FULLTIME;
                return new Fulltime(employee.Name, employee.Surname);
            else
                //employee.TypeOfContract = TypeOfContractEnum.INTERNSHIP;
                return new Internship(employee.Name, employee.Surname);
        }

        public double Salary()
        {
            return PaySalary;
        }

        public static Employee ChangeSalary(Employee employee)
        {
            if (employee.TypeOfContract == TypeOfContractEnum.INTERNSHIP)
                
                return new Internship(employee.Name, employee.Surname);
            else
                //employee.TypeOfContract = TypeOfContractEnum.INTERNSHIP;
                return new Fulltime(employee.Name, employee.Surname);
        }
        //public double Salary(TypeOfContractEnum typeOfContract)
        //{
        //    if (TypeOfContract == TypeOfContractEnum.INTERNSHIP)
        //        return PaySalary=Salary(typeOfContract);
        //}


        public override string ToString()
        {
            return "Name: "+Name.ToString()+" Surename: "+Surname.ToString()+" Sallary: "+PaySalary.ToString()+" Contract: "+TypeOfContract.ToString();
        }
    }
}
