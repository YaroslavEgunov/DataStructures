using System;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int _hours;

        private int _minutes;

        private int _seconds;

        public Time()
        {
        }

        public Time(int hours, int minutes, int seconds)
        {
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
        }

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value <= 0  || value > 24)
                {
                    throw new ArgumentException("В сутках не более 24-ёх и не отрицательное значение");
                }
                _hours = value;
            }
        }

        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value <= 0  || value > 60)
                {
                    throw new ArgumentException("В часе не более 60-ти и не отрицательное значение");
                }
                _minutes = value;
            }
        }

        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value <= 0 || value > 60)
                {
                    throw new ArgumentException("В минуте не более 60-ти и не отрицательное значение");
                }
                _seconds = value;
            }
        }
    }
}
