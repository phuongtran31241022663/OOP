using System.Security.Cryptography;
using System.Text;
using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Users
    {
        private int id;
        private string name;
        private string phone;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public string GetPhone()
        {
            return phone;
        }

        public void SetPhone(string value)
        {
            phone = value;
        }
    }
}
