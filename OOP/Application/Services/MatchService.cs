using OOP.Domain.Interfaces;

namespace OOP.Application.Services
{
    public class MatchService
    {
        private readonly IUserRepository userRepo;
        private readonly ITripRepository tripRepo;

        public MatchService(IUserRepository userRepo, ITripRepository tripRepo)
        {
            this.userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
            this.tripRepo = tripRepo ?? throw new ArgumentNullException(nameof(tripRepo));
        }
      
    }
}
