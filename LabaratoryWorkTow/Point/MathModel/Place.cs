namespace LabaratoryWorkTow.Point.MathModel
{
    public class Place
    {
        private Point pointOne;
        private Point pointTow;

        public Place(Point pointOne, Point pointTow) {
            this.pointOne = pointOne;
            this.pointTow = pointTow;
        }

        public Point PointOne {
            get { 
                return pointOne; 
            }
        }

        public Point PointTow
        {
            get { 
                return pointTow; 
            }
        }
    }
}
