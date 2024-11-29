using LaboratoryElevenLib.Matrix;

namespace LaboratoryElevenLib.Array;

/// <summary>
/// Класс реализующий правила построения массивов из матрицы.
/// </summary>
internal static class RuleArray
{
    /// <summary>
    /// Получить массив из элементов над главной диогональю.
    /// </summary>
    public static double[] GetElementsAboveMainDiagonal(double[,] matrix)
    {
        int minimalLengthOfMatrix = MatrixConvention.GetMinimalLengthOfMatrix(matrix);
        int counter = 0;
        double[] result = new double[minimalLengthOfMatrix * minimalLengthOfMatrix];

        for (int row = 0; row < minimalLengthOfMatrix; row++)
        {
            for (int column = row + 1; column < minimalLengthOfMatrix; column++)
            {
                result[counter] = matrix[row, column];
                counter = counter + 1;
            }
        }

        System.Array.Resize(ref result, counter);
        return result;
    }
    
    /// <summary>
    /// Получить массив из элементов матрици, кратные 3.
    /// Если элемент = 0, он входит в массив.
    /// </summary>
    public static double[] GetElementsMultiplesOfThree(double[,] matrix)
    {
        double[] result = MatrixFormatter.GetEmptyArrayByMatrix(matrix);
        MarkingMatrix markingMatrix = MatrixConvention.GetMarkingMatrix(matrix);
        int counter = 0;

        for (int row = 0; row < markingMatrix.LengthOfMatrixByRow; row++)
        {
            for (int column = 0; column < markingMatrix.LengthOfMatrixByColumn; column++)
            {
                double element = matrix[row, column];
                if (element % 3 == 0)
                {
                    result[counter] = matrix[row, column];
                    counter = counter + 1;
                }
            }
        }

        System.Array.Resize(ref result, counter);
        return result;
    }
    
    /// <summary>
    /// Получить массив из из суммы четных положительных элементов по столбцу.
    /// </summary>
    public static double[] GetSumOfEvenElementsByColumns(double[,] matrix)
    {
        double[] result = MatrixFormatter.GetEmptyArrayByMatrix(matrix);
        MarkingMatrix markingMatrix = MatrixConvention.GetMarkingMatrix(matrix);
        int counter = 0;

        for (int column = 0; column < markingMatrix.LengthOfMatrixByColumn; column++)
        {
            double sum = 0;
            for (int row = 0; row < markingMatrix.LengthOfMatrixByRow; row++)
            {
                double element = matrix[row, column];
                if (element % 2 == 0 && element > 0)
                {
                    sum = sum + matrix[row, column];
                }
            }

            result[counter] = sum;
            counter = counter + 1;
        }

        System.Array.Resize(ref result, counter);
        return result;
    }

    /// <summary>
    /// Получить массив из максимальных элементов по столбцу.
    /// </summary>
    public static double[] GetElementsColumnMaximum(double[,] matrix)
    {
        double[] result = MatrixFormatter.GetEmptyArrayByMatrix(matrix);
        MarkingMatrix markingMatrix = MatrixConvention.GetMarkingMatrix(matrix);
        int counter = 0;

        for (int column = 0; column < markingMatrix.LengthOfMatrixByColumn; column++)
        {
            double maxOfElement = 0;
            for (int row = 0; row < markingMatrix.LengthOfMatrixByRow; row++)
            {
                double element = Math.Abs(matrix[row, column]);
                if (element > maxOfElement)
                {
                    maxOfElement = element;
                }
            }

            result[counter] = maxOfElement;
            counter = counter + 1;
        }

        System.Array.Resize(ref result, counter);
        return result;
    }
}