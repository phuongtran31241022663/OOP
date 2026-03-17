using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Trip
    {
        private int tripId;
        private string startLocation;
        private string endLocation;

        public int GetTripId()
        {
            return tripId;
        }

        public void SetTripId(int value)
        {
            tripId = value;
        }

        public string GetStartLocation()
        {
            return startLocation;
        }

        public void SetStartLocation(string value)
        {
            startLocation = value;
        }

        public string GetEndLocation()
        {
            return endLocation;
        }

        public void SetEndLocation(string value)
        {
            endLocation = value;
        }
    }
}