using HomeWorkOne.Clock.Service;
using System;

namespace HomeWorkOne
{
    public static class Starter
    {
        public static void Main(string[] args)
        {
            GeometryClockService geometryClockService = new GeometryClockService();

            Console.WriteLine("Введите часы (до 12): ");
            string hourString = Console.ReadLine();
            Console.WriteLine("Введите митнуты (до 60): ");
            string minutesString = Console.ReadLine();
            Console.WriteLine("Введите секунды (до 60): ");
            string secondString = Console.ReadLine();

            ushort hour = ushort.Parse(hourString);
            ushort minutes = ushort.Parse(minutesString);
            ushort second = ushort.Parse(secondString);

            double degreeHandOnDial = geometryClockService.getAngleByStartOfTime(hour, minutes, second);

            Console.WriteLine("Стралка наклонена на " + degreeHandOnDial + " градусов, относительно стартовой позиции цифирблата"); 
        }
    }
}