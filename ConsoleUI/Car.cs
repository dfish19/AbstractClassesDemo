using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasDoors { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine($"I have a {Year} {Make} {Model}");
        }
        public override void DriveVirtual()
        {
            base.DriveVirtual();
            
        }
    }
}
