using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Point2D
    {
        private double _pointY;

        private double _pointX;

        public Point2D()
        {
        }

        public Point2D(double PointY, double PointX)
        {
            _pointY = PointY;
            _pointX = PointX;
        }

        public double PointY
        {
            get
            {
                return _pointY;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(PointY));
                _pointY = value;
            }
        }

        public double PointX
        {
            get
            {
                return _pointX;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(PointX));
                _pointX = value;
            }
        }
    }
}
