using System;
using System.Collections.Generic;
using System.Text;
using VehicleFactoryDemo.AbstractProduct;

namespace VehicleFactoryDemo.ConcreteProduct
{
    public class Truck_Vehicle_Product : Vehicle, FuelTankCap
    {
        public int MaxLoad { get; set; }
        public int NoOfAxles { get; set; }
        public int FuelTankCapacity { get; set; }
    }
}
