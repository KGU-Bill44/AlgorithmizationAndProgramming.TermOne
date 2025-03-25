namespace LaboratoryThree.Equations
{
    public class ResultQuadraticEquation
    {
        public double FirstRoot { get; private set; }
        public double SecondRoot { get; private set; }
        public string Error { get; private set; }

        public ResultQuadraticEquation()
        {
        }

        public ResultQuadraticEquation(double firstRoot, double secondRoot)
        {
            this.FirstRoot = IfZeroAbs(firstRoot);
            this.SecondRoot = IfZeroAbs(secondRoot);
        }

        public ResultQuadraticEquation(double root)
        {
            this.FirstRoot = this.SecondRoot = IfZeroAbs(root);
        }

        public ResultQuadraticEquation(string error)
        {
            this.Error = error;
        }

        private double IfZeroAbs(double root)
        {
            if (root == 0.0)
            {
                return Math.Abs(root);
            }

            return root;
        }
    }
}