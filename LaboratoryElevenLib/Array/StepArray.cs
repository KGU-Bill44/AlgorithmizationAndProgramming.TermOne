using LaboratoryElevenLib.Matrix;

namespace LaboratoryElevenLib.Array;

public static class StepArray
{
    public static double[][] CreateByRule(double[,] matrix)
    {
        MarkingMatrix markingMatrix = MatrixConvention.GetMarkingMatrix(matrix);

        /*if (lengthOfMatrixByColumn != lengthOfMatrixByRow)
        {
            matrix = CreateSquareMatrix
        }*/

        double[][] stepArray = new double[4][];

        stepArray[0] = RuleArray.GetElementsAboveMainDiagonal(matrix);
        stepArray[1] = RuleArray.GetElementsMultiplesOfThree(matrix);

        return stepArray;
    }
}