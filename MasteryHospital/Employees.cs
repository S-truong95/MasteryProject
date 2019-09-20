using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Employees
    {
        //public string Doctors { get; set; }
        //public string Nurses { get; set; }
        //public string Janitor { get; set; }
        //public string Receptionist { get; set; }
        //public string patients { get; set; }

        public string name { get; set; }
        public int id { get; set; }
        public int salary { get; set; }
        public int pay { get; set; }

        List<Employees> employees = new List<Employees>();

        public void ViewAllEmployees()
        {
            foreach (Employees employee in employees)
            {
                Console.WriteLine("Name : " + employee.name);
                Console.WriteLine("ID : " + employee.id);
                Console.WriteLine("Salary : " + employee.salary);
                Console.WriteLine("Employee Paid : " + employee.pay);
            }
            
        }
        public void CreateEmployees()
        {
            employees.Add(new Doctors());
            employees.Add(new Nurses());
            employees.Add(new Receptionist());
            employees.Add(new Janitor());
        }
    }
}
