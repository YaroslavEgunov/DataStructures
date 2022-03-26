using System;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _durationInMinutes;

        private int _year;

        private double _rating;
        public string Genre { get; set; }
        public string Title { get; set; }

        public Movie()
        {
        }

        public Movie(string title, int year, double rating, int durationInMinutes, string genre)
        {
            Title = title;
            _durationInMinutes = durationInMinutes;
            _year = year;
            _rating = rating;
            Genre = genre;
        }

        public double Rating
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

        public int DurationInMinutes
        {
            get
            {
                return _durationInMinutes;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длительность фильма не может быть отрицательной");
                }
                _durationInMinutes = value;
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
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Год фильма должен быть от 1900 до текущего");
                }
                _year = value;
            }
        }
    }
}
