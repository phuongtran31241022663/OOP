using OOP.Domain.Entities;

namespace OOP.Domain.Interfaces
{
    public interface IUserRepo
    {
        Task<User?> GetById(Guid id);
        Task<User?> GetByPhone(string phone);
        Task<bool> Exists(string phone);
        Task Add(User user);
        Task Update(User user);
        Task<List<User>> GetAll();
    }
}
