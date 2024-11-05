namespace HomeWorkEight.Engine
{
    /// <summary>
    /// Класс для работы с минимумами/максимумами в массивах.
    /// </summary>
    internal static class ArrayExtremum
    {

        /// <summary>
        /// Ищит максимальный положительный элемент из массива. <br/>
        /// Если в массиве нет положительного элемента, то вернется 0. <br/>
        /// Если массив null, то вернется -1. <br/>
        /// </summary>
        /// <param name="array">Массив с элементами.</param>
        /// <returns>Максимальный положительный массив.</returns>
        internal static double MaximumPositiveNumber(double[] array)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(array);

                double maxsimumOfArray = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    double element = array[i];
                    if (element > 0 && maxsimumOfArray < element)
                    {
                        maxsimumOfArray = element;
                    }
                }

                return maxsimumOfArray;
            }
            catch (ArgumentNullException ex)
            {
                return -1;
            }
        }
    }
}
