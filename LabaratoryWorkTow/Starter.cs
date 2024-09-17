using System;

namespace LabaratoryWorkTow
{
    public class Starter
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Приветсвую!");
            Console.WriteLine("Программа провряет, " +
                "что 2 (E и F) точки лежат в одной полуплоскасти!");
            Console.WriteLine("Для расчкетов необходимо получить вещественные " +
                "или целые координаты точек.");
            Console.WriteLine("Условия ввода: ");
            Console.WriteLine("Точка A и B - различны");
            Console.WriteLine("Точка C и D - не лежат на l прямой, " +
                "проходящей через точки E и F");

            Console.WriteLine("Для расчкетов необходимо получить вещественные или целые координаты точек.");

            Point.MathModel.Point aPoint = CreatePointFromConsole("A");
            Console.WriteLine();
            Point.MathModel.Point bPoint = CreatePointFromConsole("B");
            Console.WriteLine();
            Point.MathModel.Point cPoint = CreatePointFromConsole("C");
            Console.WriteLine();
            Point.MathModel.Point ePoint = CreatePointFromConsole("E");
            Console.WriteLine();
            Point.MathModel.Point fPoint = CreatePointFromConsole("F"); 
            Console.WriteLine();
        }

        private static Point.MathModel.Point CreatePointFromConsole(string pointName) {
            double x;
            double y;

            Console.WriteLine($"Введите точку {pointName}: ");
            Console.Write("X координата: ");
            string xAsString = Console.ReadLine();

            if (double.TryParse(xAsString, out double parsedX))
            {
                x = parsedX;
            } else 
            {
                Console.WriteLine("Не верно введен формат числа x.");
                throw new FormatException("Не верно введен формат числа x: " + xAsString);
            }

            Console.Write("Y координата: ");
            string yAsString = Console.ReadLine();

            if (double.TryParse(yAsString, out double parsedY))
            {
                y = parsedY;
            } else
            {
                Console.WriteLine("Не верно введен формат числа y.");
                throw new FormatException("Не верно введен формат числа y: " + yAsString);
            }

            return new Point.MathModel.Point(x, y);
        }
    }
}
