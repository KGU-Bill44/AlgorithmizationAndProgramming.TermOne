namespace HomeWorkSix
{
    public class Starter
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Приветсвую!");
            Console.WriteLine("На вход программа пинимает 3 целых числа firstResult, secondResult, C! И выводит 2 суммы числе в промежутках [firstResult,secondResult] и [secondResult,C] соответсвенно");

            int a = getNumber("firstResult");
            int b = getNumber("secondResult");
            int c = getNumber("C");

            int result = Starter.SumRange(a, b);
            Console.WriteLine("В промежутке от firstResult до secondResult сумма числе равна: " + result);
            result = Starter.SumRange(b, c);
            Console.WriteLine("В промежутке от secondResult до C сумма числе равна: " + result);
        }

        public static int SumRange(int firstResult, int secondResult)
        {
            if (firstResult > secondResult)
            {
                return 0;
            }

            int sum = 0;

            for (int i = firstResult; i <= secondResult; i++)
            {
                sum = sum + i;
            }

            return sum;
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
                throw new FormatException($"Не верно введен формат числа {numberName}: {coorAsString}. Ожидается число в формате #,##0");
            }
        }
    }
}