using ChooseDbContextGeneric.Models.VehicleModels.Base;
using ChooseDbContextGeneric.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDbContextGeneric.Models.VehicleModels
{
    internal class Bus : BaseVehicle, IStoreObject
    {
        public int Id { get; set; }
        public int MaxPassenger { get; set; }
        public string Type { get; set; }
    }
}
