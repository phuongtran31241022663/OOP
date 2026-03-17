namespace OOP.Domain.Entities
{
    public class Location
    {
        private string latitude;
        private string longitude;

        public string GetLatitude()
        {
            return latitude;
        }

        public void SetLatitude(string value)
        {
            latitude = value;
        }

        public string GetLongitude()
        {
            return longitude;
        }

        public void SetLongitude(string value)
        {
            longitude = value;
        }
    }
}}