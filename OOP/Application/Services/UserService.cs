using OOP.Domain.Interfaces;

namespace OOP.Application.Services
{
    public class UserService
    {
        private readonly IUserRepo repo;
        public UserService(IUserRepo repo)
        {
            this.repo = repo ?? throw new ArgumentNullException(nameof(repo));
        }
    }
}
