namespace LabaratoryWorkTow.Point.MathModel
{
    public class Point
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

        public bool isEquelPoint(Point point) {
            return point.X == this.X && point.Y == this.Y;
        }
    }
}
