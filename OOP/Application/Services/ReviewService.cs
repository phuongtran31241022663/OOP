using OOP.Domain.Entities;
using OOP.Domain.Interfaces;
using OOP.Domain.Enums;

namespace OOP.Application.Services
{
    public class ReviewService
    {
        private readonly IReviewRepository reviewRepo;
        private readonly IUserRepository userRepo;
        private readonly ITripRepository tripRepo;

        public ReviewService(IReviewRepository reviewRepo, IUserRepository userRepo, ITripRepository tripRepo)
        {
            ArgumentNullException.ThrowIfNull(reviewRepo);
            ArgumentNullException.ThrowIfNull(userRepo);
            ArgumentNullException.ThrowIfNull(tripRepo);

            this.reviewRepo = reviewRepo;
            this.userRepo = userRepo;
            this.tripRepo = tripRepo;
        }
       
    }
}