﻿using System;


namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _width;

        private double _lenght;

        private int _id;

        private static int _allRectanglesCount;

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(double lenght, double width, string color, double PointX, double PointY)
        {
            Color = color;
            _width = width;
            _lenght = lenght;
            Center = new Point2D(PointX, PointY);
            AllRectanglesCount++;
            Id = AllRectanglesCount;
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

        public static int AllRectanglesCount { get; set; }

        public int Id { get; set; }

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
