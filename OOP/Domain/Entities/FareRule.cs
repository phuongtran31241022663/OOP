using System.Text.Json.Serialization;
using static OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class FareRule
    {
        public VehicleType VehicleType { get; init; }
        public decimal BaseFare { get; init; }
        public decimal PricePerKm { get; init; }
        public decimal CommissionRate { get; init; }

        public FareRule(
            VehicleType vehicleType,
            decimal baseFare,
            decimal pricePerKm,
            decimal commissionRate)
        {
            if (baseFare < 0 || pricePerKm < 0)
                throw new ArgumentException("Giá cước không được âm.");

            if (commissionRate < 0 || commissionRate > 1)
                throw new ArgumentException("Tỉ lệ hoa hồng phải từ 0 đến 1 (ví dụ 0.2 cho 20%).");

            VehicleType = vehicleType;
            BaseFare = baseFare;
            PricePerKm = pricePerKm;
            CommissionRate = commissionRate;
        }
       
    }
}
