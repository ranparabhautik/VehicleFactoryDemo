using System;
using System.Collections.Generic;
using System.Text;
using VehicleFactoryDemo.AbstractProduct;

namespace VehicleFactoryDemo.AbstractFactory
{
    public interface IVehicleFactory
    {
        VehicleType VehicleType { get; }
        Vehicle CreateVehicle(string Id,string VehicleNo,int price);
    }
}
