using System;
using System.Collections.Generic;
using System.Text;
/* 
* Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
* Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
* Provide the implementations for the abstract methods
* Only in the Motorcycle class will you override the virtual drive method
*/


namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
            // Just adding in an empty constructor
        }
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive.");
        }

        public bool HasTrunk { get; set; } = false;
        public bool HasDualExhaust { get; set; } = true;

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Has Trunk: {HasTrunk} | Has Dual Exhaust: {HasDualExhaust}");
        }
    }
}
