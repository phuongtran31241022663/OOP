using OOP.Domain.Entities;

namespace OOP.Domain.Interfaces
{
    public interface IPaymentRepository
    {
        Payment? GetById(Guid id);
        Payment? GetByTrip(Guid tripId);
        void Add(Payment payment);
        void Update(Payment payment);
    }
}
