namespace OOP.Domain.Entities
{
    public class Fare
    {
        private int fareId;
        private double basePrice;
        private double distance;
        private double totalFare;

        public int GetFareId()
        {
            return fareId;
        }

        public void SetFareId(int value)
        {
            fareId = value;
        }

        public double GetBasePrice()
        {
            return basePrice;
        }

        public void SetBasePrice(double value)
        {
            basePrice = value;
        }

        public double GetDistance()
        {
            return distance;
        }

        public void SetDistance(double value)
        {
            distance = value;
        }

        public double GetTotalFare()
        {
            return totalFare;
        }

        public void SetTotalFare(double value)
        {
            totalFare = value;
        }
    }
}
