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
                Validator.AssertValueInRange(value, 0, 5, nameof(Mark));
                _mark = value;
            }
        }
    }
}
