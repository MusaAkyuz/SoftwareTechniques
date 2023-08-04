using ChooseDbContextGeneric.Models.VehicleModels.Base;
using ChooseDbContextGeneric.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDbContextGeneric.Models.VehicleModels
{
    internal class Bycycle : BaseVehicle, IStoreObject
    {
        public int Id { get; set; }
        public string Jant { get; set; }
        public string KadroType { get; set; }
    }
}
