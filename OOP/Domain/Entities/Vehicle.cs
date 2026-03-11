using static OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Vehicle
    {
        public Guid VehicleId { get; }
        // Biển số xe (định danh vật lý của phương tiện)
        public string Plate { get; }
        public VehicleType Type { get; }
        public string Brand { get; }
        public string Model { get; }
        public string Color { get; }
        public int Seats { get; }
        public Vehicle(string plate, VehicleType type, string brand, string model, string color, int seats)
        {
            VehicleId = Guid.NewGuid();
            Plate = plate;
            Type = type;
            Brand = brand;
            Model = model;
            Color = color;
            Seats = seats;
        }
    }
}
