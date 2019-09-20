using System;

namespace MasteryHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to the Hospital!");
            Menu menu = new Menu();
            menu.Start();
        }
    }
}
