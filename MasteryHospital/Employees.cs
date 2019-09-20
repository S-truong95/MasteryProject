using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Employees
    {
        //Doctors doctors = new Doctors();
        //Nurses nurses = new Nurses();
        //Janitor janitor = new Janitor();
        //Receptionist receptionist = new Receptionist();
        //Patients patients = new Patients();

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
            employees.Add(new Doctors("James Groves", 1212));
            employees.Add(new Nurses("Ernest Bluford", 8888));
            employees.Add(new Receptionist("Taylor Hamphil", 5656));
            employees.Add(new Janitor("Dillon Zetzer", 7373));
        }
        public virtual void PatientCare(Patients patients)
        {

        }
        public virtual void BloodDraw(Patients patients)
        {

        }
    }
}
