using System;
using System.Collections.Generic;
using System.Text;
using VehicleFactoryDemo.AbstractProduct;

namespace VehicleFactoryDemo.ConcreteProduct
{
    public class Bike_Vehicle_Product : Vehicle, FuelTankCap
    {
        public bool HelmetIncluded { get; set; }
        public bool HaveABS { get; set; }
        public int FuelTankCapacity {  get; set; }
    }
}
