using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        private static Random Random = new Random();

        public static void RandomizeList(List<Rectangle> rectangles)
        {
            rectangles.Add(new Rectangle(
                Random.Next(10, 100),
                Random.Next(10, 100),
                "White",
                Random.Next(10, 400),
                Random.Next(10, 400)));
        }

        public static void RandomizeMassiv(Rectangle[] rectangles)
        {
            string[] RectangleColors = { "White", "Black", "Yellow", "Brown",
                "Green", "Red", "Blue", "Purple" };
            for (var i = 0; i < 5; i++)
            {
                var Colors = Random.Next(RectangleColors.Length);
                rectangles[i] = new Rectangle(Random.Next(1, 100),
                    Random.Next(1, 100),
                    RectangleColors[Colors],
                    Random.Next(1, 100),
                    Random.Next(1, 100));
            }
        }

    }
}
