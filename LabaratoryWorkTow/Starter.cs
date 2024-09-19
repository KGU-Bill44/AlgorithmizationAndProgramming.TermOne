using LabaratoryWorkTow.MathPoint.MathException;
using LabaratoryWorkTow.MathPoint.MathModel;
using LabaratoryWorkTow.MathPoint.Service;
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

            try
            {
                Point efPoint = CreatePointFromConsole("EF");
                Console.WriteLine();
                Point ghPoint = CreatePointFromConsole("GH");
                Console.WriteLine();
                Point abPoint = CreatePointFromConsole("AB");
                Console.WriteLine();
                Point cdPoint = CreatePointFromConsole("CD");
                Console.WriteLine();

                PlaneMath planeMath = new PlaneMath();

                bool result = planeMath.PointsBelongToSameHalfPlane(abPoint, cdPoint, efPoint, ghPoint);
                string resultAsString = result ? "Лежат на одной полуплоскости" : "Не лежат на одной полуплоскости";

                Console.WriteLine("Точни AB и CD: " + resultAsString);
            }
            catch (EqualsPointException ex)
            {
                Console.WriteLine("Точки EF и GH - равны");
            }
            catch (PointOnLineException ex)
            {
                Console.WriteLine("Точка AB или CD - лежит на одной прямой L (L - проходящей через точки EF и GH)");
            }
            catch (FormatException ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private static Point CreatePointFromConsole(string pointName) {
            Console.WriteLine($"Введите точку {pointName}: ");
            double x = getCoordinate("X");
            double y = getCoordinate("Y");

            return new Point(x, y);
        }

        private static double getCoordinate(string coordinateName) {
            Console.Write($"{coordinateName} координата: ");
            string xAsString = Console.ReadLine();

            if (double.TryParse(xAsString, out double parsedX))
            {
                return parsedX;
            }
            else
            {
                throw new FormatException($"Не верно введен формат числа {coordinateName}: {xAsString}. Ожидается число в формате ##0,###");
            }
        }
    }
}
