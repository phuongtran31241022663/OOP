using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Admin : Users
    {
        private string role;

        public string GetRole()
        {
            return role;
        }

        public void SetRole(string value)
        {
            role = value;
        }
    }
}
