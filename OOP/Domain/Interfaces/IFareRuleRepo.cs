using OOP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using static OOP.Domain.Enums;

namespace OOP.Domain.Interfaces
{
    public interface IFareRuleRepo
    {
        Task<FareRule> GetByType(VehicleType type);
        Task Save(FareRule rule);
    }
}
