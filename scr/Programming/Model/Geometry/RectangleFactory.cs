using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class RectangleFactory
    {
        private static Random random = new Random();

        public static void Randomize(List<Rectangle> rectangles)
        {
            rectangles.Add(new Rectangle(
                random.Next(10, 100),
                random.Next(10, 100),
                "White",
                random.Next(10, 400),
                random.Next(10, 400)));
        }
    }
}
