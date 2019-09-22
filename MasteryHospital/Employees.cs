using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Employees
    {

        public string name { get; set; }
        public int id { get; set; }
        public string special { get; set; }
        public int salary { get; set; }
        public bool pay { get; set; }

        List<Employees> employees = new List<Employees>();

        public void ViewAllEmployees()
        {
            foreach (Employees employee in employees)
            {
                Console.WriteLine("Name: " + employee.name);
                Console.WriteLine("ID: " + employee.id);
                Console.WriteLine("Salary: " + employee.salary);
                Console.WriteLine("Employee Pay: " + employee.pay);
                Console.WriteLine("Specailty: " + employee.special);
                Console.WriteLine();
            }

        }
        public void PayEmployees()
        {
            if (pay == false)
            {
                Console.WriteLine($"{name} pay is {salary}");
                pay = true;
            }
            else Console.WriteLine($"{name} has already been paid");
        }
        public void SinglePay()
        {
            Console.WriteLine("\nPlease select a employee from list");
            Employees employee = employees[Convert.ToInt32(Console.ReadLine()) - 1];
            employee.PayEmployees();
        }
        public void CreateEmployees()
        {
            employees.Add(new Doctors("James Groves", 1212, "Heart Surgeon"));
            employees.Add(new Doctors("Jen Evans", 2222, "Brain Surgeon"));

            employees.Add(new Nurses("Justin Brown", 8888, "Patient care"));
            employees.Add(new Nurses("Ernest Bluford", 8899, "Patient care"));

            employees.Add(new Receptionist("Taylor Hamphil", 5656, "Cleaning"));
            employees.Add(new Receptionist("Mike Mosier", 5643, "CLeaning"));

            employees.Add(new Janitor("Dillon Zetzer", 7337, "Answering Calls"));
            employees.Add(new Janitor("William Harris", 7373, "ANswering Calls"));
        }
        public virtual void PatientCare(Patients patients)
        {

        }
        public virtual void BloodDraw(Patients patients)
        {

        }
        public Employees EmployeeMenu()
        {

            int employeeNumber = 1;
            foreach (Employees employee in employees)
            {
                Console.WriteLine($"{employeeNumber} {employee.name} {employee.id}");
                employeeNumber++;
            }
            return null;

        }
    }
}
