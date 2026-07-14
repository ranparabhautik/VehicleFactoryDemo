using System;
using System.Collections.Generic;
using System.Text;
using VehicleFactoryDemo.AbstractFactory;
using VehicleFactoryDemo.AbstractProduct;
using VehicleFactoryDemo.ConcreteProduct;
using VehicleFactoryDemo.Enums;

namespace VehicleFactoryDemo.ConcreteFactory;

public class Bike_Factory : IVehicleFactory
{
    public VehicleType VehicleType => VehicleType.Bike;

    public Vehicle CreateVehicle(string VehicleNo, string ModelName, string color, int price)
    {
        return new Bike_Vehicle_Product
        {
            VehicleNo = VehicleNo,
            ModelName = ModelName,
            Color = color,
            Price = price,
            FuelTankCapacity = 3,
            fuelType = FuelType.Petrol,
            HaveABS = true,
            HelmetIncluded  = false,
            Manifacturer = "Royal Enfield",
            ManufacturingDate = DateTime.Now,
            SeatingCapacity = 2, 
            VehicleType = VehicleType.Bike
        };
    }
}
