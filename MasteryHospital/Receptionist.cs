using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Receptionist : Employees
    {
        public Receptionist(string Name, int Number)
        {
            base.id = Number;
            base.name = Name;
        }
    }
}
