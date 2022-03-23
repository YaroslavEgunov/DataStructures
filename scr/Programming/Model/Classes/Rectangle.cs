using System;


namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _width;
        private double _heigth;
        private string _color { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(double heigth, double width, string color)
        {
            _color = color;
            _width = width;
            _heigth = heigth;
        }

        void SetWigth (Rectangle rectangle, int width)
        {
            if (width<=0)
            {
                throw new ArgumentException("Ширина не может быть отрицательной");
            }
            rectangle._width = width;
        }

        void SetHeight(Rectangle rectangle, int height)
        {
            if (height <= 0)
            {
                throw new ArgumentException("Длина не может быть отрицательной");
            }
            rectangle._heigth = height;
        }

    }
}
