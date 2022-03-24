using System;


namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _width;
        private double _heigth;
        public string Color { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(double heigth, double width, string color)
        {
            Color = color;
            _width = width;
            _heigth = heigth;
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
                    throw new ArgumentException("Ширина не может быть отрицательной");
                }

                _width = value;
            }
        }

        public double Height
        {
            get
            {
                return _heigth;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Длина не может быть отрицательной");
                }

                _heigth = value;
            }
        }
    }
}
