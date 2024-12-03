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
        /// Создает массив по 1 переданному правилу.
        /// </summary>
        /// <param name="matrix">Квадратная матрица.</param>
        /// <param name="rule">Привило построения массива.</param>
        /// <returns>Массив из элементов, после применения правилам в виде строки</returns>
        public static string GetArrayAsStringFromMatrixByRule(double[,] matrix, Rule rule)
        {
            double[] array = GetArrayFromMatrixByRule(matrix, rule);
            return string.Join(", ", array);
        }

        /// <summary>
        /// Создает массив по правилам.
        /// </summary>
        /// <param name="matrix">Квадратная матрица.</param>
        /// <param name="rules">Привила построения массива.</param>
        /// <returns>Массив из элементов, после применения правил в виде строк.</returns>
        public static string[] GetArrayFromMatrixByRule(double[,] matrix, Rule[] rules)
        {
            string[] array = new string[rules.Length];

            for (int ruleIndex = 0; ruleIndex < rules.Length; ruleIndex++)
            {
                array[ruleIndex] = GetArrayAsStringFromMatrixByRule(matrix, rules[ruleIndex]);
            }

            return array;
        }
    }
}