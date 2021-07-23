using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Unicycle : IVehicle
    {
        public int amountOfTires()
        {
            int tires = 1;
            if (tires == 1)
            {
                Console.WriteLine("Your building a UNICYCLE");
            }
            else
            {
                return 1;
            }
            return tires;
        }
    }
}
