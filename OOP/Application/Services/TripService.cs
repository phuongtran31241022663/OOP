using OOP.Domain.Entities;
using OOP.Domain.Interfaces;
using OOP.Domain.Enums;

namespace OOP.Application.Services
{
    public class TripService
    {
        private readonly ITripRepository tripRepo;
        private readonly IUserRepository userRepo;
        private readonly IFareRepository fareRepo;
        public TripService(
           ITripRepository tripRepo,
           IUserRepository userRepo,
           IFareRepository fareRepo)        {
            this.tripRepo = tripRepo ?? throw new ArgumentNullException(nameof(tripRepo));
            this.userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
            this.fareRepo = fareRepo ?? throw new ArgumentNullException(nameof(fareRepo));
        }
      
    }
}
