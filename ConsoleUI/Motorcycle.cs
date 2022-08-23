using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool GoesFast { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine($"I have a {Year} {Make} {Model}");
        }
        public override void DriveVirtual()
        {
            //base.DriveVirtual();
            Console.WriteLine();
            Console.WriteLine("On a nice day... you can always find me catching turns!");
            
        }
    }
}

