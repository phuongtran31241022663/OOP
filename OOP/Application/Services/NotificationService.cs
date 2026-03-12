using System;
using System.Collections.Generic;
using OOP.Domain.Entities;

namespace OOP.Application.Services
{
    public class NotificationService
    {
        public event Action<Trip>? TripRequested;
        public event Action<Trip>? TripMatched;
        public event Action<Trip>? TripCompleted;

        public void NotifyTripRequested(Trip trip)
        {
            TripRequested?.Invoke(trip);
        }

        public void NotifyTripMatched(Trip trip)
        {
            TripMatched?.Invoke(trip);
        }

        public void NotifyTripCompleted(Trip trip)
        {
            TripCompleted?.Invoke(trip);
        }
    }
}
