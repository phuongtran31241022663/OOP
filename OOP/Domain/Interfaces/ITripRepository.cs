using OOP.Domain.Entities;

namespace OOP.Domain.Interfaces
{
    public interface ITripRepository
    {
        Task<Trip?> GetById(Guid id);
        Task<List<Trip>> GetByPassengerId(Guid Id);
        Task<List<Trip>> GetByDriverId(Guid Id);
        Task Add(Trip trip);
        Task Update(Trip trip);
    }
}
