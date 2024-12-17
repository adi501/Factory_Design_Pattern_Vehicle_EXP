using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_Vehicle_EXP
{
    public class Truck : IVehicle
    {
        public void Manufacture()
        {
            Console.WriteLine("Truck is being manufactured.");
        }
    }
}
