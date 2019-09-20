using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Janitor : Employees
    {
        public Janitor(string Name, int Number)
        {
            base.id = Number;
            base.name = Name;
        }
    }
}
