using OOP.Domain.Entities;
using OOP.Domain.Interfaces;
using OOP.Domain.Enums;

namespace OOP.Application.Services
{
    public class FareService
    {
        private readonly IFareRuleRepo repo;

        public FareService(IFareRuleRepo repo)
        {
            this.repo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

      
    }
}
