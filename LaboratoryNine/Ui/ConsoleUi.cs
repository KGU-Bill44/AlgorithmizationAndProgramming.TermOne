using LaboratoryNine.Engine;

namespace LaboratoryNine.Ui
{
    internal class ConsoleUi
    {
        /// <summary>
        /// Вход в консолное прилоджение.
        /// </summary>
        public static void Run()
        {
            PrintWelcome();
            PrintInfoTask();
            try
            {
                int n = GetNumberFromConsole("N");
                double[] array = GetArrayByCount(n);

                double[] result = ArrayStatistics.AverageByElement(array);

                PrintArray(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введеная строка не соответсвует формату числа");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Число вышло за рамки допустимых значений");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }

        private static void PrintArray(double[] result)
        {
            Console.Write("Сформировани следующий массив: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }

        /// <summary>
        /// Метод чтений элементов массива из консоли.
        /// </summary>
        /// <param name="n">Количество элементов в массиве</param>
        /// <returns>Собранный элемент</returns>
        private static double[] GetArrayByCount(int n)
        {
            double[] array = new double[n];

            for (int indexOfElement = 0; indexOfElement < n; indexOfElement++)
            {
                Console.Write($"Введите значение элемента {indexOfElement + 1}: ");
                double anyDouble = double.Parse(Console.ReadLine());
                array[indexOfElement] = anyDouble;
            }

            return array;
        }

        /// <summary>
        /// Выводит в консоль приветсвия для пользователя.
        /// </summary>
        private static void PrintWelcome()
        {
            Console.WriteLine("Приветсвую!");
        }

        /// <summary>
        /// Выводит в консоль информацию о решаемой задачи.
        /// </summary>
        private static void PrintInfoTask()
        {
            Console.Write(
                "Программа на вход программа принимает массив из N элемиентов. \n" +
                "И формирует новый массив из среднеарефметоческого всех элементов от K до N\n");
        }

        /// <summary>
        /// Метод получения из консоли число.
        /// </summary>
        /// <returns>Число типа int</returns>
        /// <param name="nameForVarible">Название числа</param>
        private static int GetNumberFromConsole(string nameForVarible)
        {
            Console.Write($"Введите {nameForVarible}: ");
            string anyString = Console.ReadLine();
            return int.Parse(anyString);
        }
    }
}
