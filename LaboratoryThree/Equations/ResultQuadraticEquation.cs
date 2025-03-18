namespace LaboratoryThree.Equations
{
    public class ResultQuadraticEquation
    {
        public double FirstRoot { get; private set; }
        public double SecondRoot { get; private set; }
        public string Error { get; private set; }

        public ResultQuadraticEquation() { }
        public ResultQuadraticEquation(double firstRoot, double secondRoot)
        {
            this.FirstRoot = firstRoot;
            this.SecondRoot = secondRoot;
        }

        public ResultQuadraticEquation(double root)
        {
            this.FirstRoot = root;
            this.SecondRoot = root;
        }

        public ResultQuadraticEquation(string error)
        {
            this.Error = error;
        }
    }
}
