using LaboratoryThree.TimeModel;
using LaboratoryThree.Util;
using System.Runtime.InteropServices.JavaScript;

namespace LaboratoryThree
{
    public static class Starter
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Приветсвую");
            Console.WriteLine("Программа вычисляет по значению дня и месяца предыдущий день.");

            try
            {
                ushort day = GetUshort("день", TimeUtil.DayRange);
                ushort month = GetUshort("день", TimeUtil.MonthRange);

                Console.WriteLine("Предыдущая дата была:" + TimeUtil.GetDayBefore(day, month));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка" + ex.Message);
            }
            catch (ArgumentOutOfRangeException ex) {
                Console.WriteLine("Ошибка:" + ex.InnerException);
            }
        }

        private static ushort GetUshort(string nameOfVar, RangeOfTime range)
        {
            Console.Write($"Введинте, пожалусто, {nameOfVar}, значение ожидается в формате ##0,## и в границах от {range.MinValue} и до {range.MaxValue}:");
            string anyString = Console.ReadLine();
            if (ushort.TryParse(anyString, out ushort namber))
            {
                return namber;
            }
            else
            {
                throw new FormatException($"Строка {anyString} не соответсвует формату числа ##0,##");
            }
        }
    }
}
