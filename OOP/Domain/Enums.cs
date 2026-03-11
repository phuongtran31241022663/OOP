using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Domain
{
    public class Enums
    {
        public enum UserRole
        {
            Passenger,
            Driver,
            Admin
        }
        public enum DriverStatus
        {
            Busy,
            Available
        }
        public enum TripStatus
        {
            Requested,
            Matched,
            Arrived,
            Ongoing,
            Completed,
            Cancelled
        }
        public enum VehicleType
        {
            Motorbike,
            Car
        }
        public enum PaymentStatus
        {
            Unpaid,
            Paid
        }
    }
}
