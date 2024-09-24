namespace LaboratoryThree.Utils
{
    internal static class SimpeOperationUtil
    {
        public static bool IsZero(double number) {
            return number == 0;
        }

        public static bool SignificantNumber(double number)
        {
            return !IsZero(number);
        }
    }
}
