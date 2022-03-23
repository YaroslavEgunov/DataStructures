using System;

namespace Programming.Model.Classes
{
    public class Film
    {
        private string _title { get; set; }
        private int _duration;
        private int _year;
        private string _genre { get; set; }
        private int _rating;

        public Film()
        {
        }

        public Film(int duration, int yearOfRelease, int rating, string title, string genre)
        {
            _duration = duration;
            _year = yearOfRelease;
            _rating = rating;
            _title = title;
            _genre = genre;
        }


        void SetRating(Film film, int rating)
        {
            if (rating > 10 || rating < 0)
            {
                throw new ArgumentException("Рейтинг от 0 до 10");
            }
            film._rating = rating;
        }

        void SetDuration(Film film, int duration)
        {
            if (duration < 0)
            {
                throw new ArgumentException("Длительность фильма не может быть отрицательной");
            }
            film._duration = duration;
        }

        void SetYear(Film film, int year)
        {
            if (year < 1900 || year > 2022)
            {
                throw new ArgumentException("Год фильма должен быть от 1900 до текущего");
            }
            film._year = year;
        }
    }
}
