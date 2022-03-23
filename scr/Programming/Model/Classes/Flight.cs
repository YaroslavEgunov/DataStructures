using System;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private string _destination { get; set; }
        private string _departurePoint { get; set; }
        private int _flightTime;

        public Flight()
        {
        }

        public Flight(int flightTime, string departurePoint, string destination)
        {
            _flightTime = flightTime;
            _departurePoint = departurePoint;
            _destination = destination;
        }

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
            flight._flightTime = flightTime;
        }

    }
}
