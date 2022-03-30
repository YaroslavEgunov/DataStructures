using System;


namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _width;

        private double _length;
        public string Color { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(double length, double width, string color)
        {
            Color = color;
            _width = width;
            _length = length;
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ширина не может быть отрицательной или равной 0");
                }

                _width = value;
            }
        }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Длина не может быть отрицательной или равной 0");
                }

                _length = value;
            }
        }
    }
}
