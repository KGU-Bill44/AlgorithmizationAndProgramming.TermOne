using System;

namespace LabaratoryWorkTow.MathPoint.MathModel
{
    public class Point : IEquatable<Point>
    {
        private double x;
        private double y;

        public Point(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public bool Equals(Point point) {
            return point != null && point.X == this.X && point.Y == this.Y;
        }
    }
}
