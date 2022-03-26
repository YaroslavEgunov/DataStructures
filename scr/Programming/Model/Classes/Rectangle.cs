using System;


namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _width;

        private double _lenght;
        public string Color { get; set; }

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
                if (value <= 0)
                {
                    throw new ArgumentException("Ширина не может быть отрицательной или равной 0");
                }

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
                if (value <= 0)
                {
                    throw new ArgumentException("Длина не может быть отрицательной или равной 0");
                }

                _lenght = value;
            }
        }

    }
}
