using OOP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Domain.Interfaces
{
    public interface ITripRepo
    {
        Task<Trip?> GetById(Guid id);
        Task<List<Trip>> GetByUserId(Guid Id);
        Task Add(Trip trip);
        Task Update(Trip trip);
    }
}
