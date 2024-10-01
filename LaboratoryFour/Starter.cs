public class Starter
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Приветсвую!");
            Console.WriteLine("Программа высчитывет сумму из N действиетльных чисел");
            Console.Write("Введите число N - количество числе. " +
                "Формат ввода: ###0. Больше 0 и не бесконечное: ");

            string anyString = Console.ReadLine();

            if (uint.TryParse(anyString, out uint countOfNumbers))
            {
                if (countOfNumbers == 0)
                {
                    Console.WriteLine("Множество значений - пустое. Сумма всех элементов равна 0");
                    return;
                }

                double sum = 0;
                for (int indextOfNumber = 1; indextOfNumber <= countOfNumbers; indextOfNumber++)
                {
                    double anyNum = getDoubleFromConsole($"Введите {indextOfNumber} число: ", "0,##");
                    sum += anyNum;
                }
                Console.WriteLine($"Сумма получившиеся чисел: {sum:F3}.");
            }
            else
            {
                Console.WriteLine("Ошибка введения: введена строка не соответсвующая формату числа ###0. Число бессконечное или отрицательное");
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }

    }

    private static double getDoubleFromConsole(string showString, string fromatString)
    {
        Console.Write(showString);
        string anyString = Console.ReadLine();

        if (double.TryParse(anyString, out double number))
        {
            return number;
        }
        else
        {
            throw new FormatException($"Ошибка введения: введена строка не соответсвующая формату числа {fromatString}.");
        }
    }
}