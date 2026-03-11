using OOP.Domain.Entities;
using OOP.Domain.Interfaces;
using static OOP.Domain.Enums;

namespace OOP.Application.Services
{
    public class TripService
    {
        private readonly ITripRepo tripRepo;
        private readonly IUserRepo userRepo;
        private readonly IFareRuleRepo fareRepo;
        public TripService(
           ITripRepo tripRepo,
           IUserRepo userRepo,
           IFareRuleRepo fareRepo)        {
            this.tripRepo = tripRepo ?? throw new ArgumentNullException(nameof(tripRepo));
            this.userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
            this.fareRepo = fareRepo ?? throw new ArgumentNullException(nameof(fareRepo));
        }
      
    }
}
