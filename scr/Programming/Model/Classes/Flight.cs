using System;

namespace Programming.Model.Classes
{
    public class Flight
    {
        public string Destination { get; set; }
        public string DeparturePoint { get; set; }
        private int _flightTime;

        public Flight()
        {

        }

        public Flight(int flightTime, string departurePoint, string destination)
        {
            _flightTime = flightTime;
            DeparturePoint = departurePoint;
            Destination = destination;
        }

        public int FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                if (value > 24)
                {
                    throw new ArgumentException("Полёты не длятся более 24 часов");
                }
                if (value < 0)
                {
                    throw new ArgumentException("Длительность полёта не может быть отрицательной");
                }
                _flightTime = value;
            }
        }
    }
}
