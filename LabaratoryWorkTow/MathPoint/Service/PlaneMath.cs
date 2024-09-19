using LabaratoryWorkTow.MathPoint.MathException;
using LabaratoryWorkTow.MathPoint.MathModel;

namespace LabaratoryWorkTow.MathPoint.Service
{
    internal class PlaneMath
    {
        public bool PointsBelongToSameHalfPlane(Point pointOne, Point pointTow, Line dividingLine) {
            LineMath dividingLineMath = new LineMath(dividingLine);
            IfPointOnLineException(pointOne, dividingLineMath);
            IfPointOnLineException(pointTow, dividingLineMath);

            double yOnePoint = dividingLine.GetYByX(pointOne.X);
            double yTowPoint = dividingLine.GetYByX(pointTow.X);

            return RealYMoreCalcY(yOnePoint, pointOne.Y) == RealYMoreCalcY(yTowPoint, pointTow.Y);
        }

        public void IfPointOnLineException(Point point, LineMath dividingLineMath) {
            if (dividingLineMath.IsPointOnLine(point)) {
                throw new PointOnLineException($"Point with {point.X}, {point.Y} - defined on line");
            }
        }

        private bool RealYMoreCalcY(double realY, double calcY) {
            return realY > calcY;
        }

        public bool PointsBelongToSameHalfPlane(Point pointOne, Point pointTow, Point onePointOfdividingLine, Point towPointOfdividingLine)
        {
            return this.PointsBelongToSameHalfPlane(pointOne, pointTow, new Line(onePointOfdividingLine, towPointOfdividingLine));
        }
    }
}
