using System;
using System.Collections.Generic;
using System.Text;
using VehicleFactoryDemo.AbstractFactory;
using VehicleFactoryDemo.Enums;

namespace VehicleFactoryDemo.FactoryProvider;

public interface IVehicleFactoryProvider
{
    IVehicleFactory GetFactory(VehicleType Typee);
}
