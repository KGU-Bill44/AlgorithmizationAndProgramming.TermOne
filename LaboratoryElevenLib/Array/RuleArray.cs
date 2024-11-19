using LaboratoryElevenLib.Matrix;

namespace LaboratoryElevenLib.Array;

internal static class RuleArray
{
    public static double[] GetElementsAboveMainDiagonal(double[,] matrix)
    {
        int minimalLengthOfMatrix = MatrixConvention.GetMinimalLengthOfMatrix(matrix);
        int counter = 0;
        double[] result = new double[minimalLengthOfMatrix ^ 2];

        for (int row = 1; row < minimalLengthOfMatrix; row++)
        {
            for (int column = 0; column < row; column++)
            {
                result[counter] = matrix[row, column];
                counter = counter + 1;
            }
        }

        System.Array.Resize(ref result, counter);
        return result;
    }

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
                if (element % 3 != 0)
                {
                    result[counter] = matrix[row, column];
                }

                counter = counter + 1;
            }
        }
        
        System.Array.Resize(ref result, counter);
        return result;
    }
}