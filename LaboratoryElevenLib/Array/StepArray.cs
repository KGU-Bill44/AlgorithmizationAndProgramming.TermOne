using LaboratoryElevenLib.Input;
using LaboratoryElevenLib.Type;

namespace LaboratoryElevenLib.Array;

public static class StepArray
{
    /// <summary>
    /// Заготовленный набор правил, для задачи.
    /// </summary>
    public static void Do(double[,] matrix)
    {
        ConsoleOutput.PrintStruct(matrix);
        
        ArrayRuleCreator.CreateAndOutArrayFromMatrixByRule(matrix,
        [
            Rule.ElementsAboveMainDiagonal,
            Rule.ElementsMultiplesOfThree,
            Rule.SumOfEvenElementsByColumns,
            Rule.ElementsColumnMaximum
        ]);
    }
}