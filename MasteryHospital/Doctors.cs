using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Doctors : Employees
    {
        public Doctors(string Name, int Number, string Special)
        {
            id = Number;
            name = Name;
            special = Special;
            pay = false;
            salary = 150000;
        }
        public override void PatientCare(Patients patients)
        {
            patients.health += 10;
            Console.WriteLine("Patient health : " + patients.health);
        }
        public override void BloodDraw(Patients patients)
        {
            patients.bloodLevel -= 20;
            Console.WriteLine("Patient blood level : " + patients.bloodLevel);
        }
    }
}
