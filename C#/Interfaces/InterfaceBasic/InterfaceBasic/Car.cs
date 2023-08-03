using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasic
{
    internal class Car : ICar
    {
        void ICar.Drive()
        {
            Console.WriteLine("Drive");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
