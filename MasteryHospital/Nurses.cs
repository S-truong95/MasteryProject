using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Nurses : Employees
    {
        public bool withPatient { get; set; }
        public Nurses(string Name, int Number, string Special)
        {
            special = Special;
            id = Number;
            name = Name;
            pay = false;
            salary = 65000;
            withPatient = false;
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
