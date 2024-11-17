namespace HomeWorkTen.Engine;

public static class MatrixDiagonals
{
    public static double AverageSideDiagonal(double[,] matrix)
    {
        int countOfRows = matrix.GetLength(0);
        int countOfColumns = matrix.GetLength(1);
        int indexOfColumn = countOfColumns - 1;
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