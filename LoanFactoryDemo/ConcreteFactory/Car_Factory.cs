using System;
using System.Collections.Generic;
using System.Text;
using VehicleFactoryDemo.AbstractFactory;
using VehicleFactoryDemo.AbstractProduct;
using VehicleFactoryDemo.ConcreteProduct;

namespace VehicleFactoryDemo.ConcreteFactory
{
    public class Car_Factory : IVehicleFactory
    {
        public VehicleType VehicleType => VehicleType.Car;

        public Vehicle CreateVehicle(string Id,string VehicleNo,int price)
        {
            return new Car_Vehicle_Product()
            {
                Id = Id,
                HaveSunroof = true,
                ModelName = "Creta",
                VehicleNo = VehicleNo,
                VehicleType = VehicleType.Car,
                FuelTankCapacity = 10,
                Color = "White",
                fuelType = FuelType.Petrol,
                IsAutoTransMission = true,
                Manifacturer = "Tata",
                ManufacturingDate = DateTime.Now.AddDays(-10),   
                Price = price,
                 SeatingCapacity = 5

            };
        }
    }
}
