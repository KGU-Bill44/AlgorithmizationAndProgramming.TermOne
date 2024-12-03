using LaboratoryTwelve.Engine;

namespace LaboratoryTwelve.Ui;

public class Ui
{
    public class ConsoleUi
    {
        /// <summary>
        /// Вход в консолное прилоджение.
        /// </summary>
        public static void Run()
        {
            PrintWelcome();
            PrintInfoTask();
            
            string anyString = GetNumberFromConsole("строку");
            StringEditor.ConvertLatinToLowercase(ref anyString);

            Console.WriteLine(anyString);
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
                "Программа переобразовывает все прописные латинские буквы встрочные по введенной строке. \n");
        }

        /// <summary>
        /// Метод получения из консоли число.
        /// </summary>
        /// <returns>Число типа int</returns>
        /// <param name="nameForVarible">Название числа</param>
        private static string GetNumberFromConsole(string nameForVarible)
        {
            Console.Write($"Введите {nameForVarible}: ");
            return Console.ReadLine();
        }
    }
}