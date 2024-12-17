using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_Vehicle_EXP.Factory
{
    public class VehicleFactory
    {
        public IVehicle CreateVehicle(string vehicleType)
        {
            switch (vehicleType)
            {
                case "Car":
                    return new Car();
                case "Bike":
                    return new Bike();
                case "Truck":
                    return new Truck();
                default:
                    throw new ArgumentException("Invalid vehicle type.");
            }
        }
    }
}
