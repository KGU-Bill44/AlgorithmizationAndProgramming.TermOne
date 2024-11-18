namespace HomeWorkEight.Engine
{
    /// <summary>
    /// Класс для работы с минимумами/максимумами в массивах.
    /// </summary>
    internal static class ArrayExtremum
    {
        /// <summary>
        /// Ищит минимальный положительный элемент из массива. <br/>
        /// Если в массиве нет положительного элемента, то вернется 0. <br/>
        /// Если массив null, то вернется -1. <br/>
        /// </summary>
        /// <param name="array">Массив с элементами.</param>
        /// <returns>Минимальный положительный массив.</returns>
        internal static double MinimumPositiveNumber(double[] array)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(array);

                if (array.Length == 0)
                {
                    return 0;
                }

                double minimumOfArray = double.MaxValue;

                for (int i = 0; i < array.Length; i++)
                {
                    double element = array[i];
                    if (element > 0)
                    {
                        if (element < minimumOfArray)
                        {
                            minimumOfArray = element;
                        }
                    }
                }

                return minimumOfArray == double.MaxValue ? 0 : minimumOfArray;
            }
            catch (ArgumentNullException)
            {
                return -1;
            }
        }
    }
}
