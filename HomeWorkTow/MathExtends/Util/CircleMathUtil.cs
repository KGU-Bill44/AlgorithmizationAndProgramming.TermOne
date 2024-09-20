using HomeWorkTow.MathExtends.MathModel;

namespace HomeWorkTow.MathExtends.Service
{
    internal static class CircleMathUtil
    {
        public static bool PointInCircle(Point point, double radius) {
           return Math.Pow(point.X, 2) + Math.Pow(point.Y, 2) <= Math.Pow(radius, 2);
        }

        public static bool PointOutOfCircle(Point point, double radius)
        {
            return !PointInCircle(point, radius);
        }
    }
}
