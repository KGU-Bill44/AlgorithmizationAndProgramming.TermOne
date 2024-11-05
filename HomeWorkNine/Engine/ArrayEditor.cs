namespace HomeWorkNine.Engine
{
    /// <summary>
    /// Класс, специализирующийся на изменении массива.
    /// </summary>
    internal static class ArrayEditor
    {
        /// <summary>
        /// Изменяет массив: меняет местами первую и вторую половину массива.
        /// </summary>
        /// <param name="array">Массив, который будет переобразован.</param>
        internal static void SwopByHalf(double[] array)
        {
            if (array == null)
            {
                return;
            }

            int halfLenght = array.Length / 2;
            int centerOfArray = array.Length % 2;

            for (int index = 0; index < halfLenght; index++)
            {
                (array[index], array[index + halfLenght + centerOfArray]) = (array[index + halfLenght + centerOfArray], array[index]);
            }
        }
    }
}
