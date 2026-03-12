using System.Security.Cryptography;
using static OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Driver : User
    {
        public double MaxPickup { get; set; }
        public DriverStatus Status { get; private set; }
        public Location Position { get; private set; }
        public int License { get; }
        public Vehicle Vehicle { get; private set; }
        // Tài chính
        public decimal Wallet { get; private set; }
        public decimal Income { get; private set; }
        // Đánh giá
        private int ratingCount;
        private decimal ratingTotal;
        public decimal Rating => ratingCount == 0 ? 5.0m : Math.Round(ratingTotal / ratingCount, 2);
        public Driver(
      Guid id,
      string name,
      string phone,
      string hashedPassword,
      bool isActive,
      int license,
      Vehicle vehicle,
      DriverStatus status,
      decimal wallet)
      : base(id, name, phone, hashedPassword, isActive, UserRole.Driver)
        {
            License = license;
            Vehicle = vehicle ?? throw new ArgumentNullException(nameof(vehicle));
            Status = status;
            Wallet = wallet;
            MaxPickup = vehicle.Type == VehicleType.Car ? 5 : 3;
        }
    }
}
