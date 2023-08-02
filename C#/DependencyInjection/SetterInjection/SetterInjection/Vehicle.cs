using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetterInjection
{
    internal class Vehicle
    {
        //IVehicle _vehicle { get; set; }

        //veya

        IVehicle _vehicle;

        public void SetVehicleType(IVehicle vehicle)
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
