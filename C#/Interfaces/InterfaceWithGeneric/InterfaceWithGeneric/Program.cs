using InterfaceWithGeneric.Models;

namespace InterfaceWithGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass<Bycycle> bycycle = new BaseClass<Bycycle>();
            bycycle.Print();
            bycycle.Read();
            Console.WriteLine(bycycle.ClassName());

            BaseClass<Car> car = new BaseClass<Car>();
            car.Print();
            car.Read();
            Console.WriteLine(car.ClassName());
        }
    }
}