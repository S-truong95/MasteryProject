using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Patients
    {
        public int health { get; set; }
        public int bloodLevel { get; set; }

        public Patients()
        {
            health = 50;
            bloodLevel = 60;
        }
        public void PatientStats()
        {
            Console.WriteLine($"bloodlevel: {bloodLevel}");
            Console.WriteLine($"health: {health}");
        }
    }
}
