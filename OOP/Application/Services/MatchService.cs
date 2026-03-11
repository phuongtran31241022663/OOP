using OOP.Domain.Entities;
using OOP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using static OOP.Domain.Enums;

namespace OOP.Application.Services
{
    public class MatchService
    {
        private readonly IUserRepo userRepo;
        private readonly ITripRepo tripRepo;

        public MatchService(IUserRepo userRepo, ITripRepo tripRepo)
        {
            this.userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
            this.tripRepo = tripRepo ?? throw new ArgumentNullException(nameof(tripRepo));
        }
      
    }
}
