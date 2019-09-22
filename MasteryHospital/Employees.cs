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
        public virtual void EmployeeInfo()
        {
            
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
        public void Status()
        {
            Employees employee = employees[Convert.ToInt32(Console.ReadLine()) - 1];
            employee.EmployeeInfo();

        }
        public void CreateEmployees()
        {
            employees.Add(new Doctors("James Groves (doctor)", 1212, "Heart Surgeon"));
            employees.Add(new Doctors("Jen Evans (doctor)", 2222, "Brain Surgeon"));

            employees.Add(new Nurses("Justin Brown (nurse)", 8888, "Patient care"));
            employees.Add(new Nurses("Ernest Bluford (nurse)", 8899, "Patient care"));

            employees.Add(new Receptionist("Taylor Hamphil (receptionist)", 5656, "Cleaning"));
            employees.Add(new Receptionist("Mike Mosier (receptionist)", 5643, "CLeaning"));

            employees.Add(new Janitor("Dillon Zetzer (janitor)", 7337, "Answering Calls"));
            employees.Add(new Janitor("William Harris (janitor)", 7373, "Answering Calls"));
        }
        public void PatientCare(Patients patients)
        {
            patients.health += 10;
            Console.WriteLine("Patient health : " + patients.health);
        }
        public void BloodDraw(Patients patients)
        {
            patients.bloodLevel -= 20;
            Console.WriteLine("Patient current blood level : " + patients.bloodLevel);
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
        public void Care(Patients patients)
        {
            Console.WriteLine("Would you like to draw blood or care for your patient?");
            Console.WriteLine("1. blood draw");
            Console.WriteLine("2. care for patient");
            string care = Console.ReadLine();
            switch (care)
            {
                case "1":
                    Console.WriteLine("Would you like the doctor or nurse to draw your blood?");
                    Console.WriteLine("1. Doctor");
                    Console.WriteLine("2. Nurse");
                    string worker = Console.ReadLine();
                    switch (worker)
                    {
                        case "1":
                            BloodDraw(patients);
                            Console.WriteLine("You drew blood from patient");
                            break;
                        case "2":
                            BloodDraw(patients);
                            Console.WriteLine("You drew blood from patient");
                            break;
                        
                    
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("Would you like the doctor or nurse to care for you?");
                        Console.WriteLine("1. Doctor");
                        Console.WriteLine("2. Nurse");
                        string specialist = Console.ReadLine();
                        switch (specialist)
                        {
                            case "1":
                                PatientCare(patients);
                                Console.WriteLine("You cared for patient");
                                break;
                            case "2":
                                PatientCare(patients);
                                Console.WriteLine("You cared for patient");
                                break;
                          
                        }
                        break;
                    }
            }
        }
    }
}
