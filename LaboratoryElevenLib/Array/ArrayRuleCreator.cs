using LaboratoryElevenLib.Type;

namespace LaboratoryElevenLib.Array
{
    internal static class ArrayRuleCreator
    {
        public static double[] GetArrayFromMatrixByRule(double[,] matrix, Rule rule)
        {
            return rule switch
            {
                Rule.ElementsAboveMainDiagonal => RuleArray.GetElementsAboveMainDiagonal(matrix),
                Rule.ElementsMultiplesOfThree => RuleArray.GetElementsMultiplesOfThree(matrix),
                Rule.SumOfEvenElementsByColumns => RuleArray.GetSumOfEvenElementsByColumns(matrix),
                Rule.ElementsColumnMaximum => RuleArray.GetElementsColumnMaximum(matrix)
            };
        }

        public static double[][] GetArrayFromMatrixByRule(double[,] matrix, params Rule[] rules)
        {
            double[][] array = new double[rules.Length][];

            for (int ruleIndex = 0; ruleIndex < rules.Length; ruleIndex++)
            {
                array[ruleIndex] = GetArrayFromMatrixByRule(matrix, rules[ruleIndex]);
            }

            return array;
        }
    }
}