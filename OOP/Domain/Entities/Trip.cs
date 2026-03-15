using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Trip
    {
        // 1. Các thông tin định danh
        public Guid Id { get; init; }
        public Guid PassengerId { get; init; }
        public Guid? DriverId { get; private set; }
        public TripStatus Status { get; private set; }

        // 2. Thông tin lộ trình và giá cước
        public Location Pickup { get; init; }
        public Location Dropoff { get; init; }
        public double Distance { get; init; } // km
        public decimal Fare { get; init; }
        public VehicleType Type { get; init; }
        // 3. Thời gian và lý do (nếu có)
        public DateTime CreatedAt { get; init; }
        public string? Reason { get; private set; }
        public Trip(
            Guid passengerId,
            Location pickup,
            Location dropoff,
            double distance,
            decimal fare,
            VehicleType type)
        {
            if (distance <= 0) throw new ArgumentException("Distance must be > 0");
            if (fare <= 0) throw new ArgumentException("Fare must be > 0");

            Id = Guid.NewGuid();
            PassengerId = passengerId;
            Pickup = pickup ?? throw new ArgumentNullException(nameof(pickup));
            Dropoff = dropoff ?? throw new ArgumentNullException(nameof(dropoff));
            Distance = distance;
            Fare = fare;
            Type = type;
            Status = TripStatus.Requested; // Mặc định khi tạo là đang yêu cầu
            CreatedAt = DateTime.Now;
            DriverId = null;
        }
        
    }
}
