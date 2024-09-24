using LabaratoryWorkTow.MathPoint.MathException;
using System;

namespace LabaratoryWorkTow.MathPoint.MathModel
{
    public class Line
    {
        private Point pointOne;
        private Point pointTow;

        private double k;
        private double b;

        public Line(Point pointOne, Point pointTow) {

            if (pointOne.Equals(pointTow))
            {
                throw new EqualsPointException();
            }

            this.pointOne = pointOne;
            this.pointTow = pointTow;

            CreateLineFunction(pointOne, pointTow);
        }

        private void CreateLineFunction(Point pointOne, Point pointTow)
        {
            // y = kx + b
            double dkopx = Math.Max(pointTow.X, pointOne.X)  - Math.Min(pointTow.X, pointOne.X);
            double dkopy = Math.Max(pointTow.Y, pointOne.Y) - Math.Min(pointTow.Y, pointOne.Y);
            
            if (dkopx == 0) { 
                k = 0; 
            }
            else
            {
                k = dkopy / dkopx;
            }

            b = pointOne.Y - (k * pointOne.X);
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

        public double GetYByX(double x) {
            return k * x + b;
        }
    }
}
