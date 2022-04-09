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
                Validator.AssertValueInRange(value,1,1440, nameof(FlightTimeInMinutes));
                _flightTimeInMinutes = value;
            }
        }
    }
}
