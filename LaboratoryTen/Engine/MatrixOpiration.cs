namespace LaboratoryTen.Engine
{
    internal static class MatrixOpiration
    {
        /// <summary>
        /// Находим количество элементов, больших среднего арифметического всего столбца.
        /// </summary>
        /// <param name="matrix">Матрица размером N на M</param>
        /// <returns>Массив из M элементов, с количеством в соответсвии состолбцом.</returns>
        internal static int[] CountOfElementsGreaterAverageArefmetric(double[,] matrix)
        {
            if (matrix == null)
            {
                return new int[0];
            }

            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            int[] result = new int[m];

            for (int column = 0; column < m; column++)
            {
                double sumOfColumn = 0;
                double[] rowAsLine = new double[n];

                for (int row = 0; row < n; row++)
                {
                    rowAsLine[row] = matrix[row, column];
                    sumOfColumn = sumOfColumn + rowAsLine[row];
                }

                double avg = sumOfColumn / n;
                result[column] = CountOfElementGreaterThan(rowAsLine, avg);
            }

            return result;
        }


        /// <summary>
        /// Метод считае количество элементов, больших чем переданное число.
        /// </summary>
        private static int CountOfElementGreaterThan(double[] rowAsLine, double operand)
        {
            int count = 0;

            foreach (double element in rowAsLine)
            {
                if (element > operand)
                {
                    count++;
                }
            }

            return count;
        }
    }
}