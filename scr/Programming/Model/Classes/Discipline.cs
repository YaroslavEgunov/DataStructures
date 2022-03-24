using System;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        public string Subject { get; set; }
        private int _grade;
        public string TeachersName { get; set; }

        public Discipline()
        {
        }

        public Discipline(string subject, string teachersname, int grade)
        {
            Subject = subject;
            TeachersName = teachersname;
            _grade = grade;
        }

        public int Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                if (value <= 1 || value > 5)
                {
                    throw new ArgumentException("Оценка не может быть отрицательной или больше 5");
                }
                _grade = value;
            }
        }
        
    }
}
