namespace HomeWorkTen.Engine;

/// <summary>
/// Класс, для управления матричными диоганалями.
/// </summary>
public static class MatrixDiagonals
{

    /// <summary>
    /// Высчитывает среднее арефметическое побочной диаганали квадратной матрицы. 
    /// </summary>
    public static double AverageSideDiagonal(double[,] matrix)
    {
        int countOfRows = matrix.GetLength(0);

        if (countOfRows == 0)
        {
            throw new ArgumentException("Невозможно всчитать среднее арефметическое у пустой матрцы");
        }

        double sum = 0;
        int cuont = 0;

        for (int row = countOfRows - 1; row > -1; row--)
        {
            sum = sum + matrix[row, cuont];
            cuont = cuont + 1;
        }

        return sum / cuont;
    }

}