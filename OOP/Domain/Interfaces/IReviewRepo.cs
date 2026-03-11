using OOP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Domain.Interfaces
{
    public interface IReviewRepo
    {
        Task Add(Review review);
        Task<List<Review>> GetByDriverId(Guid driverId);
        Task<bool> Exists(Guid tripId);
        Task<List<Review>> GetAll();
    }
}
