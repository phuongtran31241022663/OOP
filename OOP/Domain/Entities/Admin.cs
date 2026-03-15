using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Admin : User
    {
        public Admin(
            Guid Id,
            string name,
            string phone,
            string hashedPassword,
            bool isActive)
            : base(Id, name, phone, hashedPassword, isActive, UserRole.Admin)
        {
        }
      
    }
}
