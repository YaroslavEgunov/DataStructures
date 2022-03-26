using System;

namespace Programming.Model.Classes
{
    public class Subject
    {
        private int _mark;
        public string Name { get; set; }

        public string TeacherName { get; set; }

        public Subject()
        {
        }

        public Subject(string name, string teachersname, int mark)
        {
            Name = name;
            TeacherName = teachersname;
            _mark = mark;
        }

        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException("Оценка не может быть отрицательной или больше 5");
                }
                _mark = value;
            }
        }
    }
}
