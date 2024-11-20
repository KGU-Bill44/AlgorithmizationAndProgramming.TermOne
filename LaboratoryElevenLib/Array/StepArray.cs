using LaboratoryElevenLib.Matrix;
using LaboratoryElevenLib.Type;

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

        return ArrayRuleCreator.GetArrayFromMatrixByRule(matrix, Rule.ElementsAboveMainDiagonal,
            Rule.ElementsMultiplesOfThree,
            Rule.SumOfEvenElementsByColumns,
            Rule.ElementsColumnMaximum);
    }
}