using System;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private string Destination { get; set; }
        private string DeparturePoint { get; set; }
        private int FlightTime;

        void SetFlight_time(Flight flight, int flightTime)
        {
            if (flightTime > 24)
            {
                throw new ArgumentException("Полёты не длятся более 24 часов");
            }
            if (flightTime < 0)
            {
                throw new ArgumentException("Длительность полёта не может быть отрицательной");
            }
            flight.FlightTime = flightTime;
        }

    }
}
