using System;


namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private int Width;
        private int Height;
        private string Color { get; set; }

        void SetWigth (Rectangle rectangle, int width)
        {
            if (width<=0)
            {
                throw new ArgumentException("Ширина не может быть отрицательной");
            }
            rectangle.Width = width;
        }

        void SetHeight(Rectangle rectangle, int height)
        {
            if (height <= 0)
            {
                throw new ArgumentException("Длина не может быть отрицательной");
            }
            rectangle.Height = height;
        }

    }
}
