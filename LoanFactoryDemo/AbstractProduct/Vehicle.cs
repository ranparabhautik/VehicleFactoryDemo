namespace VehicleFactoryDemo.AbstractProduct;

public abstract class Vehicle:BaseEntity
{
    public string VehicleNo { get; set; }
    public string ModelName { get; set; }
    public string Manifacturer { get; set; }
    public string Color { get; set; }
    public int SeatingCapacity{ get; set; }
     public int Price { get; set; }
    public FuelType fuelType { get; set; }
    public VehicleType VehicleType { get; set; }
    public DateTime ManufacturingDate { get; set; } = DateTime.Now;

}
