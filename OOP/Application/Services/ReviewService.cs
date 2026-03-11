using OOP.Domain.Entities;
using OOP.Domain.Interfaces;
using static OOP.Domain.Enums;

namespace OOP.Application.Services
{
    public class ReviewService
    {
        private readonly IReviewRepo reviewRepo;
        private readonly IUserRepo userRepo;
        private readonly ITripRepo tripRepo;

        public ReviewService(IReviewRepo reviewRepo, IUserRepo userRepo, ITripRepo tripRepo)
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