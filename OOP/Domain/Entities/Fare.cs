using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public abstract class Fare
    {
        public VehicleType Type { get; init; }
        public decimal BaseFare { get; init; }
        public decimal PricePerKm { get; init; }
        public decimal CommissionRate { get; init; }

        public Fare(
            VehicleType type,
            decimal baseFare,
            decimal pricePerKm,
            decimal commissionRate)
        {
            if (baseFare < 0 || pricePerKm < 0)
                throw new ArgumentException("Giá cước không được âm.");

            if (commissionRate < 0 || commissionRate > 1)
                throw new ArgumentException("Tỉ lệ hoa hồng phải từ 0 đến 1 (ví dụ 0.2 cho 20%).");

            Type = type;
            BaseFare = baseFare;
            PricePerKm = pricePerKm;
            CommissionRate = commissionRate;
        }
        public abstract decimal CalculateFare(double distanceKm);
    }
    public class MotorbikeFare : Fare
    {
        public MotorbikeFare()
            : base(VehicleType.Motorbike, 8000, 3500, 0.2m) { }

        public override decimal CalculateFare(double distanceKm)
        {
            return BaseFare + (decimal)distanceKm * PricePerKm;
        }
    }

    public class CarFare : Fare
    {
        public CarFare()
            : base(VehicleType.Car, 15000, 12000, 0.25m) { }

        public override decimal CalculateFare(double distanceKm)
        {
            return BaseFare + (decimal)distanceKm * PricePerKm;
        }
    }
}
