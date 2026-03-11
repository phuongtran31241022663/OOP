using OOP.Domain;
using OOP.Domain.Entities;
using OOP.Domain.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace OOP.Application.Services
{
    public class UserService
    {
        private readonly IUserRepo Repo;
        public UserService(IUserRepo userRepo)
        {
            Repo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
        }
       
    }
}
