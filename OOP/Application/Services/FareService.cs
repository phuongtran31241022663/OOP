using OOP.Domain.Entities;
using OOP.Domain.Interfaces;
using static OOP.Domain.Enums;

namespace OOP.Application.Services
{
    public class FareService
    {
        private readonly IFareRuleRepo Repo;

        public FareService(IFareRuleRepo Repo)
        {
            this.Repo = Repo ?? throw new ArgumentNullException(nameof(Repo));
        }

      
    }
}
