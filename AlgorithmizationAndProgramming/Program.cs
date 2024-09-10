using System;

namespace AlgorithmizationAndProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int radius = 0;

            Console.Write("Введите радиус окружности: ");
            string anyString = Console.ReadLine();

            if (int.TryParse(anyString, out radius))
            {
                Console.WriteLine("Площадь = " + MathUtil.getAreaFromRadius(radius));
                Console.WriteLine("Длинна = " + MathUtil.getLengthAreaFromRadius(radius));
            }
            else
            {
                Console.WriteLine("Введено не число");
            }
            Console.ReadLine();
        }
    }
}
