namespace LaboratoryElevenLib.Matrix;

public class MatrixFormatter
{
    private static double[] GetMaximalArrayByMatrixLength(int lengthOfMatrixOne, int lengthOfMatrixTow)
    {
        return new double[lengthOfMatrixOne * lengthOfMatrixTow];
    }
    
    public static double[] GetMaximalArrayByMatrixLength(int lengthOfMatrix)
    {
        return GetMaximalArrayByMatrixLength(lengthOfMatrix, lengthOfMatrix);
    }

    public static double[] GetEmptyArrayByMatrix(double[,] matrix)
    {
        MarkingMatrix markingMatrix = MatrixConvention.GetMarkingMatrix(matrix);

        return GetMaximalArrayByMatrixLength(markingMatrix.LengthOfMatrixByColumn, markingMatrix.LengthOfMatrixByRow);
    }
}