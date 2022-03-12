using System;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private string Destination { get; set; }
        private string Departure_point { get; set; }
        private int Flight_time;

        void SetFlight_time(Flight flight, int flight_time)
        {
            if (flight_time > 24)
            {
                throw new ArgumentException("Полёты не длятся более 24 часов");
            }
            if (flight_time < 0)
            {
                throw new ArgumentException("Длительность полёта не может быть отрицательной");
            }
            flight.Flight_time = flight_time;
        }

    }
}
