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
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            // Just adding in an empty constructor
        }
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is in drive");
        }

        public bool HasSideCart { get; set; } = true;
        public bool IsHarleyDavidson { get; set; } = false;

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive.");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Has Side Cart: {HasSideCart} | Is Harley Davidson: {IsHarleyDavidson}");
        }
    }
}
