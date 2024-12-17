using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_Vehicle_EXP
{
    public class Bike : IVehicle
    {
        public void Manufacture()
        {
            Console.WriteLine("Bike is being manufactured.");
        }
    }
}
