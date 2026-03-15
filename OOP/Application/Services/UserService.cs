using OOP.Domain.Interfaces;

namespace OOP.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository repo;
        public UserService(IUserRepository repo)
        {
            this.repo = repo ?? throw new ArgumentNullException(nameof(repo));
        }
    }
}
