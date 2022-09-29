using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern01
{
    public class Semi : IVehicle
    {
        public Semi()
        {

        }

        public void Drive()
        {
            Console.WriteLine("The Semi-Truck Is blocking traffic");

        }
    }

   

}
