using System;

namespace LabaratoryWorkTow.Point.MathModel
{
    public class Line
    {
        private Point pointOne;
        private Point pointTow;

        private double k;
        private double b;

        public Line(Point pointOne, Point pointTow) {
            this.pointOne = pointOne;
            this.pointTow = pointTow;

            createLineFunction(pointOne, pointTow);
        }

        private void createLineFunction(Point pointOne, Point pointTow)
        {
            // y = kx + b
            double dkopx = pointTow.X - pointOne.X;
            double dkopy = pointTow.Y - pointOne.Y;
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
