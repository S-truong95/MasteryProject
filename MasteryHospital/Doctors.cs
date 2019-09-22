using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Doctors : Employees
    {
        public bool withPatient { get; set; }
        public Doctors(string Name, int Number, string Special)
        {
            id = Number;
            name = Name;
            special = Special;
            pay = false;
            salary = 150000;
        }
        public override void EmployeeInfo()
        {
            Random rnd = new Random();
            int OnCall = rnd.Next(1, 3);
            switch (OnCall)
            {
                case 1:
                    withPatient = false;
                    break;
                case 2:
                    withPatient = true;
                    break;
            }
            Console.WriteLine($"With patient: {withPatient}");

        }

    }
}
