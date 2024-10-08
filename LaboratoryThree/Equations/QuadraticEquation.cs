using LaboratoryThree.Utils;

namespace LaboratoryThree.Equations
{
    internal class QuadraticEquation
    {
        private double coofA;
        private double coofB;
        private double coofC;

        private string controlSum;

        public QuadraticEquation(double a, double b, double c)
        {
            this.coofA = a;
            this.coofB = b;
            this.coofC = c;

            string controlSum = $"{Convert.ToInt16(SimpeOperationUtil.SignificantNumber(a))}"
                + $"{Convert.ToInt16(SimpeOperationUtil.SignificantNumber(b))}"
                + $"{Convert.ToInt16(SimpeOperationUtil.SignificantNumber(c))}";
            this.controlSum = controlSum;
        }

        public ResultQuadraticEquation getRoot()
        {
            if (controlSum[0].Equals('1'))
            {
                double d = Math.Pow(coofB, 2) - (4 * A * C);

                if (d > 0)
                {
                    double dSqrt = Math.Sqrt(d);

                    double rF = (-B + dSqrt) / (2.0 * A);
                    double rS = (-B - dSqrt) / (2.0 * A);

                    return new ResultQuadraticEquation(rF, rS);
                }
                if (d == 0)
                {
                    double r = (-B) / (2.0 * A);
                    return new ResultQuadraticEquation(r);
                }

                return new ResultQuadraticEquation("Дейсвительных корней нет");
            }
            else if (controlSum.StartsWith("01"))
            {
                double result = -C / (B);
                return new ResultQuadraticEquation(result);
            }
            else if (controlSum.StartsWith("001"))
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
