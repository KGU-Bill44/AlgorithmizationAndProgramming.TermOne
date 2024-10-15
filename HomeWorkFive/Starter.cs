namespace HomeWorkFive
{
    public class Starter
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Приветсвую");
            Console.WriteLine("Программа находит наименьший натуральный делитель числа N");
            Console.WriteLine("Введите число N. Формат ввода ###0. Число N - больше 1.");

            try
            {
                uint N = getNumber("N");
                Console.WriteLine("Наименьший натуральный делитьель чила N: " + MathUtil.SmallestNaturalDivisor(N));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        private static uint getNumber(string numberName)
        {
            Console.WriteLine($"Введите число {numberName}: ");
            string? coorAsString = Console.ReadLine();

            if (uint.TryParse(coorAsString, out uint parsedX))
            {
                if (parsedX < 2)
                {
                    throw new ValidationException("Число не может быть меньше 2");
                }
                return parsedX;
            }
            else
            {
                throw new FormatException($"Не верно введен формат числа {numberName}: {coorAsString}. Ожидается число в формате ###0");
            }
        }
    }
}