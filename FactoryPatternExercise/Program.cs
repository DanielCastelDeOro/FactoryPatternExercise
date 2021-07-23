using System;
using System.Linq;
using System.Globalization;
using System.Configuration.Assemblies;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"How many tires do you want to use?\nYour options are 1, 2, 3, or 4");
            //var response = Console.ReadLine();
            //if (response == "2")
            //{
            //    Motorcycle motorcycle = new Motorcycle();
            //    motorcycle.amountOfTires();

            //}
            //else if (response == "3")
            //{
            //    MotorTrike motorTrike = new MotorTrike();
            //    motorTrike.amountOfTires();
            //}
            //else if (response == "1")
            //{
            //    Unicycle unicycle = new Unicycle();
            //    unicycle.amountOfTires();
            //}
            //else
            //{
            //    Car car = new Car();
            //    car.amountOfTires();
            Console.WriteLine($"How many tires do you want to use?\nYour options are 1, 2, 3, or 4");
            var userVehicle = Console.ReadLine();
            
            IVehicle vehicle = VehicleFactory.GetVehicle(userVehicle);
            vehicle.amountOfTires();
            

        }
    
    }
}
