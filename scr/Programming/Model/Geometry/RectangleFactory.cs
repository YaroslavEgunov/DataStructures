using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class RectangleFactory
    {
        private static Random Random = new Random();

        public static void Randomize(List<Rectangle> rectangles)
        {
            rectangles.Add(new Rectangle(
                Random.Next(10, 100),
                Random.Next(10, 100),
                "White",
                Random.Next(10, 400),
                Random.Next(10, 400)));
        }
    }
}
