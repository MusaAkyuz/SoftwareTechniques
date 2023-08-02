using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructerInjection
{
    internal class Vehicle
    {
        IVehicle _vehicle;

        public Vehicle(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void UseVehicle()
        {
            _vehicle.Drive();
            _vehicle.Stop();
        }
    }
}
