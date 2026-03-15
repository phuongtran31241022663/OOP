using OOP.Domain.Entities;
using OOP.Domain.Interfaces;
using OOP.Domain.Enums;

namespace OOP.Application.Services
{
    public class PaymentService
    {
        private readonly ITripRepository trips;
        private readonly IFareRepository fares;
        private readonly IUserRepository users;
        public PaymentService(ITripRepository trips, IFareRepository fares, IUserRepository users)
        {
            this.trips = trips ?? throw new ArgumentNullException(nameof(trips));
            this.fares = fares ?? throw new ArgumentNullException(nameof(fares));
            this.users = users ?? throw new ArgumentNullException(nameof(users));
        }
       
    }
}
