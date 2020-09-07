using System;
using System.Collections.Generic;

namespace DelegatesProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id = 101,Name="Aman",Salary=13000,Experience=5 });
            empList.Add(new Employee() { Id = 102, Name = "Utkarsh", Salary = 14000, Experience = 6 });
            empList.Add(new Employee() { Id = 103, Name = "Bhasker", Salary = 12000, Experience = 4 });

           IsPromotable isPromotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(empList,isPromotable);
        }
        public static bool Promote(Employee emp)
        {
            if(emp.Experience >=5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    delegate bool IsPromotable(Employee empl);
    class Employee
    {
        //AutoImplement Properties
        public int Id { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeelist, IsPromotable IsEligibleToPromote)
        {
            foreach(Employee employee in employeelist)
            {
                if(IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }

        }
    }
}
