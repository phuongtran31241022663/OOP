using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Passenger : Users
    {
        private string address;

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string value)
        {
            address = value;
        }
    }
}