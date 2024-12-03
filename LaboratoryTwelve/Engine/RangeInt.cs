namespace LaboratoryTwelve.Engine;

public class RangeInt(int minValue, int maxValue)
{
    private int minValue = minValue;
    private int maxValue = maxValue;

    public bool InRange(int value)
    {
        return minValue <= value && value <= maxValue;
    }
}