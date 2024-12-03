using LaboratoryElevenLib.Input;
using LaboratoryElevenLib.Type;

namespace LaboratoryElevenLib.Array
{
    /// <summary>
    /// Создает массив по переданным правилам.
    /// </summary>
    internal static class ArrayRuleCreator
    {
        /// <summary>
        /// Создает массив по 1 переданному правилу.
        /// </summary>
        /// <param name="matrix">Квадратная матрица.</param>
        /// <param name="rule">Привило построения массива.</param>
        /// <returns>Массив из элементов, после применения правила.</returns>
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

        /// <summary>
        /// Создает массив по правилам и выводи его в консоль.
        /// </summary>
        /// <param name="matrix">Квадратная матрица.</param>
        /// <param name="rules">Привила построения массива.</param>
        /// <returns>Массив из элементов, после применения правил в виде строк.</returns>
        public static void CreateAndOutArrayFromMatrixByRule(double[,] matrix, Rule[] rules)
        {
            for (int ruleIndex = 0; ruleIndex < rules.Length; ruleIndex++)
            {
                double[] array = GetArrayFromMatrixByRule(matrix, rules[ruleIndex]);
                ConsoleOutput.PrintStruct(array, ruleIndex == 0);
            }
        }
    }
}