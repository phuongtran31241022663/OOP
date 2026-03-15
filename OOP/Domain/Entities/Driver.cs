using System.Security.Cryptography;
using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Driver : User
    {
        public DriverStatus Status { get; private set; }
        public Location Position { get; private set; }
        public string License { get; }
        public Vehicle Vehicle { get; private set; }
        // Tài chính
        public decimal Wallet { get; private set; }
        public decimal Income { get; private set; }
        public int TotalTrips { get; private set; }
        // Đánh giá
        private int ratingCount;
        private decimal ratingTotal;
        public decimal Rating => ratingCount == 0 ? 5.0m : Math.Round(ratingTotal / ratingCount, 2);
        public Driver(
            Guid id,
            string name,
            string phone,
            string password,
            bool isActive,
            Vehicle vehicle,
            Location currentLocation,
            string license)
            : base(id, name, phone, password, isActive, UserRole.Driver)
        {
            Vehicle = vehicle ?? throw new ArgumentNullException(nameof(vehicle));
            Position = currentLocation ?? throw new ArgumentNullException(nameof(currentLocation));

            Status = DriverStatus.Available;
            Wallet = 0;
            Income = 0;
            TotalTrips = 0;
            License = license;
        }
    }
}
