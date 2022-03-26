using System;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightTimeInMinutes;
        public string Destination { get; set; }
        public string Departure { get; set; }

        public Flight()
        {
        }

        public Flight(int flightTimeInMinutes, string departure, string destination)
        {
            _flightTimeInMinutes = flightTimeInMinutes;
            Departure = departure;
            Destination = destination;
        }

        public int FlightTimeInMinutes
        {
            get
            {
                return _flightTimeInMinutes;
            }
            set
            {
                if (value > 1440)
                {
                    throw new ArgumentException("Полёты не длятся более 24 часов");
                }
                if (value < 0)
                {
                    throw new ArgumentException("Длительность полёта не может быть отрицательной");
                }
                _flightTimeInMinutes = value;
            }
        }
    }
}
