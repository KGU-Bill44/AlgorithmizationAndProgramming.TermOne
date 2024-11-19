namespace LaboratoryElevenLib.Matrix;

internal static class MatrixConvention
{
    public static int GetMinimalLengthOfMatrix(double[,] matrix)
    {
        MarkingMatrix markingMatrix = GetMarkingMatrix(matrix);
        return Math.Min(markingMatrix.LengthOfMatrixByRow, markingMatrix.LengthOfMatrixByColumn);
    }

    public static MarkingMatrix GetMarkingMatrix(double[,] matrix)
    {
        int lengthOfMatrixByRow = matrix.GetLength(0);
        int lengthOfMatrixByColumn = matrix.GetLength(1);

        return new MarkingMatrix(lengthOfMatrixByRow, lengthOfMatrixByColumn);
    }
}

internal record MarkingMatrix(int LengthOfMatrixByRow, int LengthOfMatrixByColumn);