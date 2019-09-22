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
    }
}
