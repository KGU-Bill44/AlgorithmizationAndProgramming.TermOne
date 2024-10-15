namespace LabaratorySix
{
    public class Starter
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Приветсвую!");
            Console.WriteLine("Программа вычисляющую третью степень числа A и " +
                "возвращающую ее в переменной B (A — входной, B — выходной параметр; " +
                "оба параметра являются вещественными).");

            for (int firstItNumber = 1; firstItNumber <= 5; firstItNumber++)
            {
                double numberForA = Starter.getNumber(firstItNumber);
                Starter.PowerA3(numberForA, out double result);
                Console.WriteLine($" Число A = {numberForA:f5}, а результат возведения числа в 3 степень B = {result:f5}");
            }
        }

        private static void PowerA3(double A, out double B)
        {
            B = A * A * A;
        }

        private static double getNumber(int numberName)
        {
            Console.Write($"Ввдите число под номером {numberName}: ");
            string? coorAsString = Console.ReadLine();

            if (double.TryParse(coorAsString, out double parsedX))
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