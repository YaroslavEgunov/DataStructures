using System;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        private string Subject { get; set; }
        private int Grade;
        private string Teacher_name { get; set; }

        void SetGrade(Discipline discipline, int grade)
        {
            if (grade <= 0 || grade > 5)
            {
                throw new ArgumentException("Оценка не может быть отрицательной или больше 5");
            }
            discipline.Grade = grade;
        }
    }
}
