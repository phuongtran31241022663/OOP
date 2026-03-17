using OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public class Payment
    {
        private int paymentId;
        private double amount;

        public int GetPaymentId()
        {
            return paymentId;
        }

        public void SetPaymentId(int value)
        {
            paymentId = value;
        }

        public double GetAmount()
        {
            return amount;
        }

        public void SetAmount(double value)
        {
            amount = value;
        }
    }
}