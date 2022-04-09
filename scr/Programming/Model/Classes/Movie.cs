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
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
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
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
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
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(Year));
                _year = value;
            }
        }
    }
}
