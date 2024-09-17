using LabaratoryWorkTow.Point.MathModel;

namespace LabaratoryWorkTow.Point.Plane
{
    public class PlaceMath
    {
        public Line Line { get; set; }

        public PlaceMath(Line line)
        {
            Line = line;
        }

        public PlaceMath(MathModel.Point pointOne, MathModel.Point pointTow) {
            Line = new Line(pointOne, pointTow);
        }

        public bool IsPointOnLine(MathModel.Point point) {
            
        }
    }
}
