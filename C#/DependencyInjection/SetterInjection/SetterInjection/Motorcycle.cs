using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetterInjection
{
    internal class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Motorcycle is being driven");
        }

        public void Stop()
        {
            Console.WriteLine("Motorcycle has stopped");
        }
    }
}
