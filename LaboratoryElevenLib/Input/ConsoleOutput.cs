﻿namespace LaboratoryElevenLib.Input;

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
    public static void PrintStruct(double[] result)
    {
        foreach (double resString in result)
        {
            Console.Write($"{resString} \t");
            
        }
        Console.WriteLine();
    }
    
    /// <summary>
    /// Выводит массив на консоль.
    /// </summary>
    public static void PrintStruct(double[] result, bool isFerst)
    {
        if (isFerst)
        {
            Console.WriteLine("Результат: ");
        }
        PrintStruct(result);
    }
}