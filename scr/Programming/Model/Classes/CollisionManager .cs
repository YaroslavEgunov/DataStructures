using System;

namespace Programming.Model.Classes
{
    public class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double differenceX = Math.Abs(rectangle1.Center.PointX - rectangle2.Center.PointX);
            double differenceY = Math.Abs(rectangle1.Center.PointY - rectangle2.Center.PointY);
            double halfDifferenceInLength = Math.Abs(rectangle1.Length - rectangle2.Length) / 2;
            double halfDifferenceInWidth = Math.Abs(rectangle1.Width - rectangle2.Width) / 2;
            return (differenceX < halfDifferenceInLength || differenceY < halfDifferenceInWidth);
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double differenceX = Math.Abs(ring1.Center.PointX - ring2.Center.PointX);
            double differenceY = Math.Abs(ring1.Center.PointY - ring2.Center.PointY);
            double hypotenuse = Math.Sqrt(differenceX * differenceX + 
                                          differenceY * differenceY);
            return (hypotenuse < (ring1.OutRadius + ring2.OutRadius));
        }
    }
}