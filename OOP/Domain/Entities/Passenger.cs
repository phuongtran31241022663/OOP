using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Passenger : User
    {
        public int TotalTrips { get; private set; }
        public Passenger(
            Guid id,
            string name,
            string phone,
            string hashedPassword,
            bool isActive)
            : base(id, name, phone, hashedPassword, isActive, UserRole.Passenger)
        {
            TotalTrips = 0;
        }

    }
}
