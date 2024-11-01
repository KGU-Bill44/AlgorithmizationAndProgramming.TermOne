using HomeWorkSeven.Engine;

namespace HomeWorkSeven.Ui
{
    public static class MathIntervalConsoleUi
    {
        public static void Run()
        {
            PrintWelcome();
            PrintInfoTask();
            try
            {
                int firstEnd = GetNumberFromConsole("первый конец");
                int secondEnd = GetNumberFromConsole("второй конец");
                MathInterval.Interval(firstEnd, secondEnd);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Введеная строка не соответсвует формату числа");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Число вышло за рамки допустимых значений");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
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
                "Программа вычисляет простые числа в промежутке [A:B].\n");
        }

        /// <summary>
        /// Метод получения из консоли число.
        /// </summary>
        /// <returns>Число типа int</returns>
        /// <param name="endName">Название числа</param>
        private static int GetNumberFromConsole(string endName)
        {
            Console.Write($"Введите {endName}: ");
            string anyString = Console.ReadLine();
            return int.Parse(anyString);
        }
    }
}