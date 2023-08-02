using System;

namespace SetterInjection
{
    class Program
    {
        private static void Main(string[] args)
        {
            Vehicle bus = new Vehicle();
            bus.SetVehicleType(new Bus());
            bus.UseVehicle();

            Vehicle motorcycle = new Vehicle();
            motorcycle.SetVehicleType(new Motorcycle());
            motorcycle.UseVehicle();

            Vehicle car = new Vehicle();
            car.SetVehicleType(new Car());
            car.UseVehicle();
        }
    }
}