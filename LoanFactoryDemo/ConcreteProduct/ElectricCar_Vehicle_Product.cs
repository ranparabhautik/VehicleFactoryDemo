using System;
using System.Collections.Generic;
using System.Text;
using VehicleFactoryDemo.AbstractProduct;

namespace VehicleFactoryDemo.ConcreteProduct
{
    public class ElectricCar_Vehicle_Product :Vehicle
    {
        public int BatteryCapacity { get; set; }
        public int RangePerCharge { get; set; }
    }
}
