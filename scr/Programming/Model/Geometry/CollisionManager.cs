using System;

namespace Programming.Model.Classes
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.Center.X < rectangle2.Center.X + rectangle2.Width &&
                rectangle1.Center.X + rectangle1.Width > rectangle2.Center.X &&
                rectangle1.Center.Y < rectangle2.Center.Y + rectangle2.Length &&
                rectangle1.Length + rectangle1.Center.Y > rectangle2.Center.Y;
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double differenceX = Math.Abs(ring1.Center.X - ring2.Center.X);
            double differenceY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double hypotenuse = Math.Sqrt(differenceX * differenceX + 
                                          differenceY * differenceY);
            return (hypotenuse < (ring1.OuterRadius + ring2.OuterRadius));
        }
    }
}