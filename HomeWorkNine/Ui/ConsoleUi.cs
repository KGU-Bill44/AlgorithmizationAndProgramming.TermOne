using HomeWorkNine.Engine;

namespace HomeWorkNine.Ui
{
    internal static class ConsoleUi
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
                ArrayEditor.SwopByHalf(array);
                PrintArray(array);
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

        /// <summary>
        /// Выводит массив на консоль.
        /// </summary>
        private static void PrintArray(double[] result)
        {
            Console.Write("Сформировани следующий массив: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]:f1} ");
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
            Console.Write("Меняет местами развые части массива, из N элементов.");
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
