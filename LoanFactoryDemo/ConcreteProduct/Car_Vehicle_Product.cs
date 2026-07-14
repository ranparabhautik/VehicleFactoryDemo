using System;
using System.Collections.Generic;
using System.Text;
using VehicleFactoryDemo.AbstractProduct;

namespace VehicleFactoryDemo.ConcreteProduct
{
    public class Car_Vehicle_Product : Vehicle, FuelTankCap
    {
        public bool HaveSunroof { get; set; }
        public bool IsAutoTransMission { get; set; }
        public int FuelTankCapacity {  get; set; }

    }
}
