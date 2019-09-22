using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Receptionist : Employees
    {
        public bool phone {get; set;} 
        public Receptionist(string Name, int Number)
        {
            phone = false;
            id = Number;
            name = Name;
            pay = false;
            salary = 48000;
        }
    }
}
