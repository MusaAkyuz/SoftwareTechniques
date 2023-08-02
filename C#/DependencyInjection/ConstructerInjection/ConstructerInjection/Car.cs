using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructerInjection
{
    internal class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is being driven");
        }

        public void Stop()
        {
            Console.WriteLine("Car is stopped");
        }
    }
}
