using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


/*
 * Create an abstract class called Vehicle
 * The vehicle class shall have three string properties Year, Make, and Model
 * Set the defaults to something generic in the Vehicle class
 * Vehicle shall have an abstract method called DriveAbstract with no implementation
 * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
 */
/* 
* Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
* Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
* Provide the implementations for the abstract methods
* Only in the Motorcycle class will you override the virtual drive method
*/

// Create a list of Vehicle called vehicles

/*
 * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
 * - new it up as one of each derived class
 * Set the properties with object initializer syntax
 */

/*
 * Add the 4 vehicles to the list
 * Using a foreach loop iterate over each of the properties
 */

// Call each of the drive methods for one car and one motorcycle

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "Generic Year";
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Generic Model";

        public abstract void DriveAbstract(); // stubbed out method

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Year: {Year} | Make: {Make} | Model: {Model}");
        }
    }
}
