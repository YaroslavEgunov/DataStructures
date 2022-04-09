using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private double _inRadius;

        private double _outRadius;

        private double _area;

        public Point2D Center { get; set; }

        public double Area
        {
            get
            {
                return _area;
            }
            private set
            {   
                Validator.AssertOnPositiveValue(value, nameof(Area));
                _area = value;
            }
        }

        public double OutRadius
        {
            get
            {
                return _outRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OutRadius));
                Validator.AssertOutRadius(value, OutRadius);
                _outRadius = value;
            }
        }

        public double InRadius
        {
            get
            {
                return _inRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InRadius));
                Validator.AssertInRadius(value, InRadius);
                _inRadius = value;
            }
        }
    }
}
