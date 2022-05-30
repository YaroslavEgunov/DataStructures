using Programming.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    public class Ring
    {
        private double _innerRadius;

        private double _outerRadius;

        public Point2D Center { get; set; }

        public Ring(double innerRadius, double outerRadius, double x, double y)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = new Point2D(x, y);
        }

        public double Area
        {
            get
            {
                return (Math.PI*(OuterRadius * OuterRadius) - (InnerRadius * InnerRadius));
            }
        }

        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertValueInRange(value, InnerRadius, double.MaxValue, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validator.AssertValueInRange(value, 0d ,OuterRadius , nameof(InnerRadius));
                _innerRadius = value;
            }
        }
    }
}
