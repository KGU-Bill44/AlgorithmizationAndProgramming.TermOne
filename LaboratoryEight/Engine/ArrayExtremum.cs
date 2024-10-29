using LaboratoryEight.Engine.InnerException;

namespace LaboratoryEight.Engine
{
    /// <summary>
    /// Класс для работы с минимумами/максимумами в массивах.
    /// </summary>
    internal static class ArrayExtremum
    {
        /// <summary>
        /// Находит количество максимальной последовательности из массива. Если передан пустой массив, то возвращается 0.
        /// </summary>
        /// <param name="array">Массив элементов типа double</param>
        /// <returns>
        /// Количество максимальной последовательности. 
        /// Если массив пустой = 0. 
        /// Если массив null = -1</returns>
        public static int FindCountMaxSequenceOfMinimalElements(double[] array)
        {
            try
            {
                if (array == null)
                {
                    throw new ArgumentNullException("array");
                }
                double minimalOfArray = FindMinimal(array);
                return FindMaximumSequenceBy(minimalOfArray, array);
            }
            catch (ArrayEmptyException e)
            {
                return 0;
            }
            catch (ArgumentNullException ex)
            {
                return -1;
            }
        }


        /// <summary>
        /// Находит минимальный элемент массива
        /// </summary>
        /// <param name="array">Не пустой массив элементов</param>
        /// <returns>Минимальный элемент</returns>
        /// <exception cref="ArrayEmptyException">В случаи, если массив пустой</exception>
        private static double FindMinimal(double[] array)
        {
            if (array.Length == 0)
            {
                throw new ArrayEmptyException("Размер массива 0!");
            }

            double minimalOfArray = double.MaxValue;
            for (int index = 0; index < array.Length; index++)
            {
                if (minimalOfArray > array[index])
                {
                    minimalOfArray = array[index];
                }
            }

            return minimalOfArray;
        }

        /// <summary>
        /// Ищет максимальную последовательность для элемента из массива
        /// </summary>
        /// <param name="number">Элемент, максимальною последоательность которого нужно найти.</param>
        /// <param name="array">Массив элементов. Может быть пустым.</param>
        /// <returns>Возвращает целое число количесва элементов в максимальной последовательности.</returns>
        private static int FindMaximumSequenceBy(double number, double[] array)
        {
            int maximumSequence = 0;
            int countCurrentSequence = 0;

            for (int index = 0; index < array.Length; index++)
            {
                double element = array[index];
                if (element == number)
                {
                    countCurrentSequence++;
                }
                else
                {
                    countCurrentSequence = 0;
                }
                if (countCurrentSequence > maximumSequence)
                {
                    maximumSequence = countCurrentSequence;
                }
            }

            return maximumSequence;
        }
    }
}
