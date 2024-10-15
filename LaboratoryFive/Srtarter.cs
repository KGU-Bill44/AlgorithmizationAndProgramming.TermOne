public class Srtarter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Приветсвую");
        Console.WriteLine("Программа прверяет введенное число, если все цифры в нем будут различные, то ответ будет true, иначе false.");


        try
        {
            int number = getNumber("N");
            bool result = true;

            while (result && number > 0)
            {
                int digistOfNumber = number % 10;
                number = number / 10;

                int setrNumber = number;

                while (result && setrNumber > 0)
                {
                    int sertDigist = setrNumber % 10;
                    setrNumber = setrNumber / 10;
                    if (sertDigist == digistOfNumber)
                    {
                        result = false;
                    }
                }
            }

            Console.WriteLine(result);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }

    private static int getNumber(string numberName)
    {
        Console.Write($"Ввдите число {numberName}: ");
        string? coorAsString = Console.ReadLine();

        if (int.TryParse(coorAsString, out int parsedX))
        {
            return parsedX;
        }
        else
        {
            throw new FormatException($"Не верно введен формат числа {numberName}: {coorAsString}. Ожидается число в формате ##0");
        }
    }
}