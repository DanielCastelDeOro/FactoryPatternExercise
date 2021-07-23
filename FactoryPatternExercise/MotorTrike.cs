using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class MotorTrike : IVehicle
    {
        public int amountOfTires()
        {
            var tires = 3;
            if (tires == 3)
            {
                Console.WriteLine("Your building a MOTOR TRIKE");
            }
            else
            {
                return 3;
            }
            return tires;
        }
    }
}
