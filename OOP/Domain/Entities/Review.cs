namespace OOP.Domain.Entities
{
    public class Review
    {
        public Guid Id { get; }
        public Guid TripId { get; }
        public Guid DriverId { get; }
        public Guid PassengerId { get; }

        public int Rating { get; }
        public string Comment { get; }
        public DateTime CreatedAt { get; }
        public Review(Guid tripId,
                      Guid driverId,
                      Guid passengerId,
                      int rating,
                      string comment)
        {
            // Validate IDs
            if (tripId == Guid.Empty) throw new ArgumentException("TripId không hợp lệ.");
            if (driverId == Guid.Empty) throw new ArgumentException("DriverId không hợp lệ.");
            if (passengerId == Guid.Empty) throw new ArgumentException("PassengerId không hợp lệ.");

            // Validate Rating
            if (rating < 1 || rating > 5)
                throw new ArgumentException("Điểm đánh giá phải từ 1 đến 5 sao.");

            // Nghiệp vụ: Đánh giá thấp (1-2 sao) thì bắt buộc có góp ý
            if (rating < 3 && string.IsNullOrWhiteSpace(comment))
                throw new ArgumentException("Vui lòng để lại góp ý nếu bạn đánh giá dưới 3 sao.");

            Id = Guid.NewGuid();
            TripId = tripId;
            DriverId = driverId;
            PassengerId = passengerId;
            Rating = rating;
            Comment = comment?.Trim() ?? string.Empty;
            CreatedAt = DateTime.Now;
        }
       
    }
}
