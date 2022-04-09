using System;


namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _width;

        private double _lenght;
        public string Color { get; set; }

        public

        public Rectangle()
        {
        }

        public Rectangle(double lenght, double width, string color)
        {
            Color = color;
            _width = width;
            _lenght = lenght;
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public double Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Lenght));
                _lenght = value;
            }
        }
    }
}
