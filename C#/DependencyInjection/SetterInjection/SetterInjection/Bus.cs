﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetterInjection
{
    internal class Bus : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bus is being driven");
        }

        public void Stop()
        {
            Console.WriteLine("Bus has stopped");
        }
    }
}
