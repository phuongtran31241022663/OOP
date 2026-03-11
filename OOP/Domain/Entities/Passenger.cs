using System.Security.Cryptography;
using static OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Passenger : User
    {
        public Location Position { get; private set; }
        public Passenger(
            Guid Id,
            string name,
            string phone,
            string hashedPassword,
            bool isActive)
            : base(Id, name, phone, hashedPassword, isActive, UserRole.Passenger)
        {
        }
        
    }
}
