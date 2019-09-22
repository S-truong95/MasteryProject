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

            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("Please select from the following menu:");
            Console.WriteLine("0. to leave Game");
            Console.WriteLine("1. View all employees");
            Console.WriteLine("2. Pay employees");

            bool inHospital = true;
            while (inHospital)
            {
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
                        employees.EmployeeMenu(employees);
                        break;
                    default:
                        Console.WriteLine("Please enter valid response");
                        break;
                }

            }
        }
    }
}
