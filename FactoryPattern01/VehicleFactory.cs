using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern01
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numWheels)

        {
            switch (numWheels)
            {
                case 2:
                    return new Motorcycle();
                case 4: 
                return new Car();

                case 6:
                    return new Semi();
                default:
                    return new Car();
            }
        }
    }
}
