using HomeWorkTow.MathExtends.MathModel;
using HomeWorkTow.MathExtends.Situation;
using HomeWorkTow.MathExtends.Util;

namespace HomeWorkTow
{
    public class Starter
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Приветсвую!");
            Console.WriteLine("Программа расчитывет, находится ли точка с координатоми X и Y ");
            Console.WriteLine($"В радиусе окружности r = {ESituation.RadiusFerstCircle} и за пределами круга с радиусом R = {ESituation.RadiusSecondCircle}");


            try
            {
                Point point = CreatePointFromConsole();
                ESituation eSituation = new ESituation();
                CircleResult resultESituation = eSituation.CheckSituation(point);
                string resultESituationAsString = resultESituation switch
                {
                    CircleResult.IN_FIRST_RANGE => "Точка входит в граници первого круга",
                    CircleResult.OUT_SECODN_RANGE => "Точка выходит за граници второго круга",
                    CircleResult.IN_INVALID_ZONE => "Точка не может входить в зону между радиусом первого и второго кругов"
                };

                Console.WriteLine(resultESituationAsString);
            }
            catch (FormatException ex) { 
                Console.WriteLine(ex.Message);
            }
        }

        private static Point CreatePointFromConsole()
        {
            Console.WriteLine($"Введите точку: ");
            double x = getCoordinate("X");
            double y = getCoordinate("Y");

            return new Point(x, y);
        }

        private static double getCoordinate(string coordinateName)
        {
            Console.Write($"{coordinateName} координата: ");
            string? coorAsString = Console.ReadLine();

            if (double.TryParse(coorAsString, out double parsedX))
            {
                return parsedX;
            }
            else
            {
                throw new FormatException($"Не верно введен формат числа {coordinateName}: {coorAsString}. Ожидается число в формате ##0,###");
            }
        }
    }
}