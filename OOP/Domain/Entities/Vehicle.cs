using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public abstract class Vehicle
    {
        public Guid Id { get; }
        public Guid DriverId { get; private set; }
        // Biển số xe (định danh vật lý của phương tiện)
        public string Plate { get; }
        public VehicleType Type { get; }
        public string Brand { get; }
        public string Model { get; }
        public string Color { get; }
        public int Capacity { get; protected set; }
        public Vehicle(
               Guid driverId,
               VehicleType type,
               string plate,
               string brand,
               string model,
               string color,
               byte capacity)
        {
            Id = Guid.NewGuid();
            DriverId = driverId;
            Plate = plate;
            Type = type;
            Brand = brand;
            Model = model;
            Color = color;
            Capacity = capacity;
        }
    }
    public class Motorbike : Vehicle
    {
        public Motorbike(Guid driverId, string plate, string brand, string model, string color)
            : base(driverId, VehicleType.Motorbike, plate, brand, model, color, 2)
        {
        }
    }
    public class Car : Vehicle
    {
        public Car(Guid driverId, string plate, string brand, string model, string color, int capacity)
            : base(driverId, VehicleType.Car, plate, brand, model, color, (byte)capacity)
        {
            if (capacity < 2 || capacity > 7)
                throw new ArgumentOutOfRangeException(nameof(capacity), "Số chỗ ngồi phải từ 2 đến 7.");
        }
    }
}
