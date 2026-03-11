using OOP.Domain.Entities;
namespace OOP.Domain.Interfaces
{
    public interface IUserRepo
    {
        Task Add(User user);
        Task<User?> GetById(Guid id);
        Task<User?> GetByPhone(string phone);
        Task<bool> Exists(string phone);
        Task Update(User user);
        Task<List<User>> GetAll();
    }
}
