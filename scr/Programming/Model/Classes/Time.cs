using System;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        void SetHours(Time time, int hours)
        {
            if (hours > 24 || hours <= 0)
            {
                throw new ArgumentException("В сутках не более 24-ёх и не менее 1-ого часа");
            }
            time._hours = hours;
        }

        void SetMinutes(Time time, int minutes)
        {
            if (minutes > 60 || minutes <= 0 )
            {
                throw new ArgumentException("В часе не более 60-ти и не менее 1-ой минуты");
            }
            time._minutes = minutes;
        }

        void SetSeconds(Time time, int seconds)
        {
            if (seconds > 60 || seconds <= 0)
            {
                throw new ArgumentException("В минуте не более 60-ти и не менее 1-ой секунды");
            }
            time._seconds = seconds;
        }

        public Time()
        {
        }

        public Time(int hours, int minutes, int seconds)
        {
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
        }

    }

   
}
