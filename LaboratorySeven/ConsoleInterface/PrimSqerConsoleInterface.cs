using LaboratorySeven.MathSituation;

namespace LaboratorySeven.ConsoleInterface
{
    /// <summary>
    /// Консльный интерфейс программы.
    /// </summary>
    public static class PrimSqerConsoleInterface
    {
        /// <summary>
        /// Метод входа в консольную оболочку программы.
        /// </summary>
        public static void ConsoleRun()
        {
            PrintWelcome();
            PrintInfoTask();
            try
            {
                long n = GetNumberFromConsole();
                bool result = MathNumber.IsNumberSquareOfPrimeNumber(n);
                if (result)
                {
                    Console.WriteLine("Число - квадрато простого числа.");
                }
                else
                {
                    Console.WriteLine("Число не является квадартом простого числа.");
                }
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
            Console.Write("Программа Дано натуральное число N. \nСоставить функцию для проверки можно ли число N представить в виде\nквадрата какого-либо простого числа.");
        }

        /// <summary>
        /// Метод получения из консоли число.
        /// </summary>
        /// <returns>Число типа long</returns>
        private static long GetNumberFromConsole()
        {
            Console.Write("Введите число N: ");
            string anyString = Console.ReadLine();
            return long.Parse(anyString);
        }
    }
}