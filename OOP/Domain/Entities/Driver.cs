using System.Security.Cryptography;
using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Driver : Users
    {
        private string licenseNumber;
        private string vehicleType;

        public string GetLicenseNumber()
        {
            return licenseNumber;
        }

        public void SetLicenseNumber(string value)
        {
            licenseNumber = value;
        }

        public string GetVehicleType()
        {
            return vehicleType;
        }

        public void SetVehicleType(string value)
        {
            vehicleType = value;
        }
    }
}