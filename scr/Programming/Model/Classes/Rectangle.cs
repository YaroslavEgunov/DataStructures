using System;


namespace Programming.Model.Classes
{
    public class Rectangle
    {
        public static int AllRectanglesCount { get; set; }

        private double _width;

        private double _length;

        public int Id { get; set; }

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public Rectangle()
        {
            AllRectanglesCount++;
            Id = AllRectanglesCount;
        }

        public Rectangle(double length, double width, string color, double x, double y)
        {
            Color = color;
            _width = width;
            _length = length;
            Center = new Point2D(x, y);
            Id = AllRectanglesCount;
            AllRectanglesCount++;
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

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }
    }
}
