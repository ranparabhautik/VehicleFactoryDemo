using System;
using System.Collections.Generic;
using System.Text;
using VehicleFactoryDemo.AbstractProduct;
using VehicleFactoryDemo.Enums;

namespace VehicleFactoryDemo.AbstractFactory
{
    public interface IVehicleFactory
    {
        VehicleType VehicleType { get; }
        Vehicle CreateVehicle(string VehicleNo,string ModelName , string color,int price);
    }
}
