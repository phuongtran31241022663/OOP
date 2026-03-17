using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Vehicle
    {
        private string vehicleName;
        private string plateNumber;

        public string GetVehicleName()
        {
            return vehicleName;
        }

        public void SetVehicleName(string value)
        {
            vehicleName = value;
        }

        public string GetPlateNumber()
        {
            return plateNumber;
        }

        public void SetPlateNumber(string value)
        {
            plateNumber = value;
        }
    }
}
