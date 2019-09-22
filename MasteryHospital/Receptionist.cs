using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Receptionist : Employees
    {
        public bool phone {get; set;} 
        public Receptionist(string Name, int Number, string Special)
        {
            special = Special;
            phone = false;
            id = Number;
            name = Name;
            pay = false;
            salary = 48000;
        }
        public override void EmployeeInfo()
        {
        Random rnd = new Random();
        int OnCall = rnd.Next(1, 3);
            switch (OnCall)
            {
                case 1:
                    phone = false;
                    break;
                case 2:
                    phone = true;
                    break;
            }
            Console.WriteLine($"On phone: {phone}");

        }
}
}
