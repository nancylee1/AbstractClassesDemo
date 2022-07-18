using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

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

            var vehicles = new List<Vehicle>();
            //List<Vehicle> vehicles = new ();      *Another way of writing the list

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            var car1 = new Car()
            {
                Year = "2022",
                Make = "Hyundai",
                Model = "Genesis",
                HasTrunk = true,
                HasDualExhaust = true
            };

            var motorcycle1 = new Motorcycle()
            {
                Year = "2022",
                Make = "Yamaha",
                Model = "Tenere 700",
                HasSideCart = false,
                IsHarleyDavidson = false
            };

            Vehicle vehicle1 = new Car()  // 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes - new it up as one of each derived class
            {
                Year = "2023",
                Make = "Lotus",
                Model = "Evija",
                HasTrunk = true,
                HasDualExhaust = true
            };

            Vehicle vehicle2 = new Motorcycle()  // 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes - new it up as one of each derived class
            {
                Year = "2023",
                Make = "Kawasaki",
                Model = "Ninja",
                HasSideCart = false,
                IsHarleyDavidson = false
            };


            /*
             * Add the 4 vehicles to the list /* In order of highest price first */
            //*/

            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);

            // *Using a foreach loop iterate over each of the properties
            foreach (var vehicle in vehicles)
            {
                //Console.WriteLine(vehicle.Year);
                //Console.WriteLine(vehicle.Make);
                //Console.WriteLine(vehicle.Model);

                //Console.WriteLine($"Year: {vehicle.Year} | Make: {vehicle.Make} | Model: {vehicle.Model}");
                vehicle.PrintInfo();   // To also print the 2 distinct properties we created (ie: HasSideCart, HasTrunk, etc...)
                vehicle.DriveAbstract();
                Console.WriteLine("----------------------------------\n");
            }


            // Call each of the drive methods for one car and one motorcycle

            car1.DriveAbstract();
            motorcycle1.DriveVirtual(); 

            #endregion            
            Console.ReadLine();
        }
    }
}
