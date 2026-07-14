using System;
using System.Collections.Generic;
using System.Text;
using VehicleFactoryDemo.AbstractFactory;
using VehicleFactoryDemo.AbstractProduct;
using VehicleFactoryDemo.ConcreteProduct;
using VehicleFactoryDemo.Enums;

namespace VehicleFactoryDemo.ConcreteFactory
{
    public class Car_Factory : IVehicleFactory
    {
        public VehicleType VehicleType => VehicleType.Car;

        public Vehicle CreateVehicle(string VehicleNo, string ModelName, string color, int price)
        {
            return new Car_Vehicle_Product
            {
                VehicleNo= VehicleNo,
                ModelName= ModelName,
                Color = color,
                Price = price,
                Manifacturer = "Tata Motors",
                VehicleType = VehicleType.Car,
                fuelType = FuelType.Petrol,
                SeatingCapacity = 5,
                ManufacturingDate = DateTime.Now,
                HaveSunroof = true,
                IsAutoTransMission = false
                
            };
        }
    }
}
