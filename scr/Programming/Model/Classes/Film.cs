using System;

namespace Programming.Model.Classes
{
    public class Film
    {
        private string Title { get; set; }
        private int Duration;
        private int Year;
        private string Genre { get; set; }
        private int Rating;

        void SetRating(Film film, int rating)
        {
            if (rating > 10 || rating < 0)
            {
                throw new ArgumentException("Рейтинг от 0 до 10");
            }
            film.Rating = rating;
        }

        void SetDuration(Film film, int duration)
        {
            if (duration < 0)
            {
                throw new ArgumentException("Длительность фильма не может быть отрицательной");
            }
            film.Duration = duration;
        }

        void SetYear(Film film, int year)
        {
            if (year < 1900 || year > 2022)
            {
                throw new ArgumentException("Год фильма должен быть от 1900 до текущего");
            }
            film.Year = year;
        }


    }
}
