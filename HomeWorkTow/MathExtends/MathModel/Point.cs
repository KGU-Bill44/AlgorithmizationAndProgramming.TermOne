namespace HomeWorkTow.MathExtends.MathModel
{
    internal struct Point
    {
        private readonly double x;
        private readonly double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public readonly double X => x;
        public readonly double Y => y;
    }
}
