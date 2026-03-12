using static OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Passenger : User
    {
        public Location Position { get; private set; }
        public Passenger(
    Guid id,
    string name,
    string phone,
    string hashedPassword,
    bool isActive,
    Location position)
    : base(id, name, phone, hashedPassword, isActive, UserRole.Passenger)
        {
            Position = position;
        }

    }
}
