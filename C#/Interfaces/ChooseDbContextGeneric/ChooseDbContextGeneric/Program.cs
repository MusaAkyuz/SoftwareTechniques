using ChooseDbContextGeneric.Contexts;
using ChooseDbContextGeneric.Models.VehicleModels;
using ChooseDbContextGeneric.Repository;
using System.Data.Entity;

namespace ChooseDbContextGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseEfRepository<Car> carRepository = new BaseEfRepository<Car>(new VehicleContext());

            carRepository.Insert(new Car { Name = "BMW", Type = "Sedan", Model = "2003", Year = "2003"});
            carRepository.Commit();
        }
    }
}