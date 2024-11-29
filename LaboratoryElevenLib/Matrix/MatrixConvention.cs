namespace LaboratoryElevenLib.Matrix;

/// <summary>
/// Матричный проектор, служебный класс, предаставляющий инфыормацию о матрице.
/// </summary>
internal static class MatrixConvention
{
    /// <summary>
    /// Находим минимум по столбцам и строкам из матрици.
    /// </summary>
    public static int GetMinimalLengthOfMatrix(double[,] matrix)
    {
        MarkingMatrix markingMatrix = GetMarkingMatrix(matrix);
        return Math.Min(markingMatrix.LengthOfMatrixByRow, markingMatrix.LengthOfMatrixByColumn);
    }

    /// <summary>
    /// Находит проектор матрицы - размерность матрице.
    /// </summary>
    public static MarkingMatrix GetMarkingMatrix(double[,] matrix)
    {
        int lengthOfMatrixByRow = matrix.GetLength(0);
        int lengthOfMatrixByColumn = matrix.GetLength(1);

        return new MarkingMatrix(lengthOfMatrixByRow, lengthOfMatrixByColumn);
    }
}