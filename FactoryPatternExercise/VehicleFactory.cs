using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    
     static class VehicleFactory
    {
       /// <param name ="newVehicle"></param>
        public static IVehicle GetVehicle(string newVehicle)
        {
            

            switch (newVehicle)
            {
                case "1":
                    return new Unicycle();
                case "2":
                    return new Motorcycle();
                case "3":
                    return new MotorTrike();
                case "4":
                    return new Car();
                default:
                    return new Unicycle();
                   // break;
            }
        }
    }
    

}
