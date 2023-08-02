using System;

namespace ConstructerInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle bus = new Vehicle(new Bus());
            bus.UseVehicle();

            Vehicle car = new Vehicle(new Car());
            car.UseVehicle();

            Vehicle motorcyle = new Vehicle(new Motorcyle());
            motorcyle.UseVehicle();
        }
    }
}