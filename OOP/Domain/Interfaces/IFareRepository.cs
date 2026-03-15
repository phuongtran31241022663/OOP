using OOP.Domain.Entities;
using OOP.Domain.Enums;

namespace OOP.Domain.Interfaces
{
    public interface IFareRepository
    {
        Fare? GetByVehicleType(VehicleType type);
        Task<List<Fare>> GetAll();
        Task<Fare> GetByType(VehicleType type);
        Task Save(Fare rule);
    }
}
