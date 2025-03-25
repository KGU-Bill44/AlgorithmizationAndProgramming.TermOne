using LaboratoryThree.Utils;

namespace LaboratoryThree.Equations
{
    public class QuadraticEquation
    {
        private double coofA;
        private double coofB;
        private double coofC;

        public QuadraticEquation(double a, double b, double c)
        {
            this.coofA = a;
            this.coofB = b;
            this.coofC = c;
        }

        public ResultQuadraticEquation GetRoot()
        {
            if (coofA != 0)
            {
                double d = Math.Pow(coofB, 2.0) - (4.0 * A * C);

                if (d > 0.0)
                {
                    double dSqrt = Math.Sqrt(d);

                    double rF = (-B + dSqrt) / (2.0 * A);
                    double rS = (-B - dSqrt) / (2.0 * A);

                    return new ResultQuadraticEquation(rF, rS);
                }
                if (d == 0.0)
                {
                    double r = (-B) / (2.0 * A);
                    return new ResultQuadraticEquation(r);
                }

                return new ResultQuadraticEquation("Дейсвительных корней нет");
            }
            else if (coofB != 0)
            {
                double result = -C / (B);
                return new ResultQuadraticEquation(result);
            }
            else if (coofC != 0)
            {
                return new ResultQuadraticEquation("Решения нет");
            }
            else
            {
                return new ResultQuadraticEquation("X - любое");
            }
        }

        public double A => this.coofA;
        public double B => this.coofB;
        public double C => this.coofC;
    }
}
