
namespace LaboratoryNine.Engine
{
    internal static class ArrayStatistics
    {
        internal static double[] AverageByElement(double[] array)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(array);

                int countOfElements = array.Length;
                double[] averageArray = new double[countOfElements];
                double sumOfElements = 0;

                for (int index = countOfElements - 1; index > -1; index--)
                {
                    sumOfElements = sumOfElements + array[index];
                    averageArray[index] = sumOfElements / (countOfElements - index);
                }

                return averageArray;
            }
            catch
            {
                return Array.Empty<double>();
            }
        }
    }
}
