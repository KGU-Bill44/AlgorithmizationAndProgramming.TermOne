namespace LaboratoryThree.TimeModel
{
    internal class RangeOfTime
    {
        public double MinValue { get; private set; }

        public double MaxValue { get; private set; }

        public RangeOfTime(double minValue, double maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }
    }
}
