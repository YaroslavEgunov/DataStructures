using System;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _duration;

        private int _year;
        private double _rating;
        public string Genre { get; set; }
        public string Title { get; set; }
        

        public Movie()
        {

        }

        public Movie(int duration, int year, double rating, string title, string genre)
        {
            _duration = duration;
            _year = year;
            _rating = rating;
            Title = title;
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
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Год фильма должен быть от 1900 до текущего");
                }
                _year = value;
            }
        }
    }
}
