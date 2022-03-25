using System;

namespace Programming.Model.Classes
{
    public class Film
    {
        
        private int _duration;
        private int _year;
        private int _rating;
        public string Genre { get; set; }
        public string Title { get; set; }
        

        public Film()
        {

        }

        public Film(int duration, int year, int rating, string title, string genre)
        {
            _duration = duration;
            _year = year;
            _rating = rating;
            Title = title;
            Genre = genre;
        }

        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new ArgumentException("Рейтинг от 0 до 10");
                }
                _rating = value;
            }
        }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длительность фильма не может быть отрицательной");
                }
                _duration = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < 1900 || value > 2022)
                {
                    throw new ArgumentException("Год фильма должен быть от 1900 до текущего");
                }
                _year = value;
            }
        }
    }
}
