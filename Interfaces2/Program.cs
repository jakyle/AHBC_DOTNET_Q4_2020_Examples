using Interfaces2.Cars;
using System;
using System.Collections.Generic;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal poodle = new Poodle();

            // PolyMorphism with Interfaces
            
            var transmissions = new List<ITransmission>();

            transmissions.Add(new Sedan());
            transmissions.Add(new Truck());

            foreach (var transmission in transmissions)
            {
                var currentGear = transmission.ChangeGear(4);

                Console.WriteLine($"My Transmission is set to the {currentGear} gear.");
            }
        }
    }
}
