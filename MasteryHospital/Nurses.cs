using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Nurses : Employees
    {
        public Nurses(string Name, int Number)
        {
            id = Number;
            name = Name;
            pay = false;
            salary = 65000;
        }
        public override void PatientCare(Patients patients)
        {
            patients.health += 10;
            Console.WriteLine("Patient current health : " + patients.health);
        }
        public override void BloodDraw(Patients patients)
        {
            patients.bloodLevel -= 20;
            Console.WriteLine("Patient current blood level : " + patients.bloodLevel);
        }

    }
}
