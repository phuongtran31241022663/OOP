using Microsoft.VisualBasic.ApplicationServices;
using OOP.Domain.Entities;
using OOP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static OOP.Domain.Enums;

namespace OOP.Application.Services
{
    public class PaymentService
    {
        private readonly ITripRepo trips;
        private readonly IFareRuleRepo fares;
        private readonly IUserRepo users;
        public PaymentService(ITripRepo trips, IFareRuleRepo fares, IUserRepo users)
        {
            this.trips = trips ?? throw new ArgumentNullException(nameof(trips));
            this.fares = fares ?? throw new ArgumentNullException(nameof(fares));
            this.users = users ?? throw new ArgumentNullException(nameof(users));
        }
       
    }
}
