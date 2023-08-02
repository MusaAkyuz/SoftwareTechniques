using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructerInjection
{
    internal class Motorcyle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("MotorCycle is being driven");
        }

        public void Stop()
        {
            Console.WriteLine("MotorCycle is stopped");
        }
    }
}
