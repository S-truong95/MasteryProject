using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Menu
    {
        public void Start()
        {
            Employees employees = new Employees();
            employees.CreateEmployees();
            Patients patients = new Patients();

            bool inHospital = true;
            while (inHospital)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("Please select from the following menu:");
                Console.WriteLine("0. to leave Game");
                Console.WriteLine("1. View all employees");
                Console.WriteLine("2. Pay employees");
                Console.WriteLine("3. Patient Care");
                Console.WriteLine("4. Patient Status");
                Console.WriteLine("5. Check if employees are working");
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "0":
                        inHospital = false;
                        break;

                    case "1":
                        Console.Clear();
                        employees.ViewAllEmployees();
                        break;

                    case "2":
                        Console.Clear();
                        employees.EmployeeMenu();
                        employees.SinglePay();
                        break;

                    case "3":
                        Console.Clear();
                        employees.Care(patients);
                        break;

                    case "4":
                        Console.Clear();
                        patients.PatientStats();
                        break;

                    case "5":
                        Console.Clear();
                        employees.EmployeeMenu();
                        employees.Status();
                        break;
                    default:
                        Console.WriteLine("Please enter valid response");
                        break;
                }

            }
        }
    }
}
