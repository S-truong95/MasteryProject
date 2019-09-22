using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Janitor : Employees
    {
        public bool sweeping { get; set; }
        public Janitor(string Name, int Number, string Special)
        {
            special = Special;
            sweeping = false;
            id = Number;
            name = Name;
            pay = false;
            salary = 40000;
        }
        public override void EmployeeInfo()
        {
            Random rnd = new Random();
            int Sweeping = rnd.Next(1, 3);
            switch (Sweeping)
            {
                case 1:
                    sweeping = false;
                    break;
                case 2:
                    sweeping = true;
                    break;
            }
            Console.WriteLine($"Sweeping: {sweeping}");
        }
    }
}
