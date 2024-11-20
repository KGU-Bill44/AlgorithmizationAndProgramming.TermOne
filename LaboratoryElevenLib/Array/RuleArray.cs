using LaboratoryElevenLib.Matrix;

namespace LaboratoryElevenLib.Array;

internal static class RuleArray
{
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