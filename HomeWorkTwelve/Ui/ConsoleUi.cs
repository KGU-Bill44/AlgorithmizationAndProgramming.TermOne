namespace HomeWorkTwelve.Ui
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
            
            string anyString = GetStringFromConsole("главную строку");
            string pattern = GetStringFromConsole("строку которую заменить");
            string substring = GetStringFromConsole("строку на которую заменить");

            anyString = anyString.Replace(pattern, substring);
            Console.WriteLine("Вывод: " + anyString);
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
            Console.Write("Программа переписывает одну подстроку в другую.\n");
        }

        /// <summary>
        /// Метод получения из консоли число.
        /// </summary>
        /// <returns>Число типа int</returns>
        /// <param name="nameForVariable">Название числа</param>
        private static string GetStringFromConsole(string nameForVariable)
        {
            Console.Write($"Введите {nameForVariable}: ");
            return Console.ReadLine();
        }
    }
}