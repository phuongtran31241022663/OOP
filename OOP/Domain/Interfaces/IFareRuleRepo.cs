using OOP.Domain.Entities;
using static OOP.Domain.Enums;

namespace OOP.Domain.Interfaces
{
    public interface IFareRuleRepo
    {
        FareRule? GetByVehicleType(VehicleType type);
        Task<List<FareRule>> GetAll();
        Task<FareRule> GetByType(VehicleType type);
        Task Save(FareRule rule);
    }
}
