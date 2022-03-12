using System;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int Hours;
        private int Minutes;
        private int Seconds;

        void SetHours(Time time, int hours)
        {
            if (hours > 24 )
            {
                throw new ArgumentException("В сутках не более 24-ёх часов");
            }
            time.Hours = hours;
        }

        void SetMinutes(Time time, int minutes)
        {
            if (minutes > 60)
            {
                throw new ArgumentException("В часе не более 60-ти минут");
            }
            time.Minutes = minutes;
        }

        void SetSeconds(Time time, int seconds)
        {
            if (seconds > 60)
            {
                throw new ArgumentException("В минуте не более 60-ти секунд");
            }
            time.Seconds = seconds;
        }

        public Time ()
        {
          
        }

        public Time (int hours, int minutes, int seconds)
        {
            SetHours(this, hours);
            SetMinutes(this, minutes);
            SetSeconds(this, seconds);
        }

    }

   
}
