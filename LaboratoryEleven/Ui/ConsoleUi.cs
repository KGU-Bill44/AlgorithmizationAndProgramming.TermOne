using LaboratoryElevenLib.Array;

namespace LaboratoryEleven.Ui;

public static class ConsoleUi
{
    /// <summary>
    /// Вход в консолное прилоджение.
    /// </summary>
    public static void Run()
    {
        PrintWelcome();
        PrintInfoTask();
        Console.WriteLine();
        try
        {
            int n = GetNumberFromConsole("размер квадратичной матрицы N");

            if (n < 0)
            {
                throw new ArgumentException("Матрца не может существовать, в которой одна из сторон меньше нуля.");
            }

            double[,] matrix = GetQuadraticMatrixCounts(n);
            StepArray.Do(matrix);
        }
        catch (FormatException)
        {
            Console.WriteLine("Введеная строка не соответсвует формату числа");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Число вышло за рамки допустимых значений");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка: " + e.Message);
        }
    }

    /// <summary>
    /// Метод чтений элементов массива из консоли.
    /// </summary>
    /// <param name="n">Количество элементов в массиве</param>
    /// <returns>Собранный элемент</returns>
    private static double[,] GetQuadraticMatrixCounts(int n)
    {
        double[,] array = new double[n, n];

        for (int indexOfLine = 0; indexOfLine < n; indexOfLine++)
        {
            for (int indexOfColumn = 0; indexOfColumn < n; indexOfColumn++)
            {
                Console.Write($"Введите значение элемента {indexOfLine + 1}, {indexOfColumn + 1}: ");
                double anyDouble = double.Parse(Console.ReadLine());
                array[indexOfLine, indexOfColumn] = anyDouble;
            }
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
        Console.Write("Программа из квадратоной матрицы создает ступечатый массив из 4 строк по следующий правилам:\n" +
                      "а) Элементы заданного массива, расположенных над главной диагональю.\n" +
                      "б) Элементы заданного массива, кратных трем.\n" +
                      "в) Каждый элемент равен сумме четных положительных элементов в соот. столбцу.\n" +
                      "г) Каждый элемент равен наибольшему по модулю элементу.\n");
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