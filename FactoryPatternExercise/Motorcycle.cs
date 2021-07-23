using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        public int amountOfTires()
        {

            var tires = 2;
           // Console.WriteLine($"How man tires do you want your vehicle to have?\nYour options are 2 or 4");
            if (tires == 2)
            {
                Console.WriteLine("Your building a MOTORCYCLE");
            }
            else
            {
                return 2;
            }
            return tires;

        }
    }
}
