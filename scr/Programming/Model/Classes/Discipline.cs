using System;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        private string _subject { get; set; }
        private int _grade;
        private string _teachersName { get; set; }

        public Discipline()
        {
        }

        public Discipline(string subject, string teachersname, int grade)
        {
            _subject = subject;
            _teachersName = teachersname;
            _grade = grade;
        }

        void SetGrade(Discipline discipline, int grade)
        {
            if (grade <= 1 || grade > 5)
            {
                throw new ArgumentException("Оценка не может быть отрицательной или больше 5");
            }
            discipline._grade = grade;
        }
    }
}
