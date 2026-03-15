using OOP.Domain.Entities;

namespace OOP.Domain.Interfaces
{
    public interface IReviewRepository
    {
        Task<Review> GetById(Guid id);
        Task<List<Review>> GetByDriverId(Guid driverId);
        Task<List<Review>> GetByPassengerId(Guid driverId);
        Task<bool> Exists(Guid tripId);
        Task<List<Review>> GetAll();
        Task Add(Review review);
    }
}
