namespace LaboratoryElevenLib.Matrix;

/// <summary>
/// Форматер матрицы - преобразуетм матрицу в другой объект.
/// </summary>
public class MatrixFormatter
{
    /// <summary>
    /// Создает пустой массив из максимального количесва элементов в матрице.
    /// </summary>
    private static double[] GetMaximalArrayByMatrixLength(int lengthOfMatrixOne, int lengthOfMatrixTow)
    {
        return new double[lengthOfMatrixOne * lengthOfMatrixTow];
    }

    /// <summary>
    /// Создает пустой массив из максимального количесва элементов в матрице.
    /// </summary>
    public static double[] GetEmptyArrayByMatrix(double[,] matrix)
    {
        MarkingMatrix markingMatrix = MatrixConvention.GetMarkingMatrix(matrix);

        return GetMaximalArrayByMatrixLength(markingMatrix.LengthOfMatrixByColumn, markingMatrix.LengthOfMatrixByRow);
    }
}