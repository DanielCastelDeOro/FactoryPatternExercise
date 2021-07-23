using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FactoryPatternExercise
{
    public class Car : IVehicle
    {
        public int amountOfTires()
        {
            int tires = 4;
           // Console.WriteLine($"How man tires do you want your vehicle to have?\nYour options are 2 or 4");
           
            if (tires == 4)
            {
                Console.WriteLine("Your building a CAR");
            }
            else
            {
                return 4;
            }
            return tires;
        }
    }
}
