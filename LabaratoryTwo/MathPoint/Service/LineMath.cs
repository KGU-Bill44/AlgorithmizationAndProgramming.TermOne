using LabaratoryWorkTow.MathPoint.MathModel;

namespace LabaratoryWorkTow.MathPoint.Service
{
    public class LineMath
    {
        public Line Line { get; }

        public LineMath(Line line)
        {
            Line = line;
        }

        public LineMath(MathModel.Point pointOne, MathModel.Point pointTow)
        {
            Line = new Line(pointOne, pointTow);
        }

        public bool IsPointOnLine(MathModel.Point point)
        {
            return point.Y == Line.GetYByX(point.X);
        }
    }
}
