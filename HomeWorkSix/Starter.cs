namespace HomeWorkSix
{
    public class Starter
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Приветсвую!");
            Console.WriteLine("На вход программа пинимает 3 целых числа A, B, C! И выводит 2 суммы числе в промежутках [A,B] и [B,C] соответсвенно");

            int a = getNumber("A");
            int b = getNumber("B");
            int c = getNumber("C");

            int result = Starter.SumRange(a, b);
            Console.WriteLine("В промежутке от A до B сумма числе равна: " + result);
            result = Starter.SumRange(b, c);
            Console.WriteLine("В промежутке от B до C сумма числе равна: " + result);
        }

        public static int SumRange(int firstResult, int secondResult)
        {
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