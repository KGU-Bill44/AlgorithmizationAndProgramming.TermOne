namespace LaboratoryElevenLib.Input;

/// <summary>
/// Класс вывода данных в консоль.
/// </summary>
internal static class ConsoleOutput
{
    /// <summary>
    /// Выводит матрицу на экран.
    /// </summary>
    public static void PrintStruct(double[,] matrix)
    {
        Console.WriteLine("Матрица:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]:f2}\t");
            }
            Console.WriteLine();
        }  
    }
    
    /// <summary>
    /// Выводит массив на консоль.
    /// </summary>
    public static void PrintStruct(double[][] result)
    {
        Console.WriteLine("Результат: ");
        foreach (double[] id in result)
        {
            foreach (double value in id)
            {
                Console.Write($"{value:f1} \t");
            }
        }
    }
}