using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2022;
        public string Make { get; set; } = "Genesis";
        public string Model { get; set; } = "G90";

        public abstract void DriveAbstract();

        public  virtual void DriveVirtual()
        {
            Console.WriteLine();
            Console.WriteLine("These vehicles are Love Love!");
            Console.WriteLine();
        }
        
    }
}
