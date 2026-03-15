using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Payment
    {
        public Guid Id { get; init; }
        public Guid TripId { get; init; }
        // Số tiền khách phải trả
        public decimal Total { get; init; }

        // Số tiền hệ thống thu (Hoa hồng)
        public decimal Commission { get; init; }
        // Số tiền thực tế tài xế nhận được
        public decimal DriverIncome { get; init; }
        public PaymentStatus Status { get; private set; }
        public Payment(Guid tripId, decimal total, decimal commissionRate)
        {
            if (tripId == Guid.Empty)
                throw new ArgumentException("TripId không hợp lệ.");

            if (total <= 0)
                throw new ArgumentException("Tổng số tiền phải lớn hơn 0.");

            if (commissionRate < 0 || commissionRate > 1)
                throw new ArgumentException("Tỉ lệ hoa hồng phải nằm trong khoảng 0-1.");

            Id = Guid.NewGuid();
            TripId = tripId;
            Total = total;

            // Tính toán ngay trong Constructor để đảm bảo tính chính xác
            Commission = Math.Round(total * commissionRate, 2);
            DriverIncome = total - Commission;

            Status = PaymentStatus.Unpaid;
        }
      
    }
}
