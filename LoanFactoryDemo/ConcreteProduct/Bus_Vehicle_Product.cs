using System;
using System.Collections.Generic;
using System.Text;
using VehicleFactoryDemo.AbstractProduct;

namespace VehicleFactoryDemo.ConcreteProduct
{
    public class Bus_Vehicle_Product : Vehicle, FuelTankCap
    {
        public int StandingCapacity { get; set; }
        public int EmergencyExitCount { get; set; }
        public int FuelTankCapacity { get; set; }
    }
}
