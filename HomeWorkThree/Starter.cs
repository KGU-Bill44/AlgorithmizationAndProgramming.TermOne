using HomeWorkThree.Model;
using LaboratoryThree.Util;

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
                ushort month = GetUshort("месяц", 1, 12);
                ushort maxMonthDay = TimeUtil.getMaxDayByMonth(month);
                ushort day = GetUshort("день", 1, maxMonthDay);

                NumberUtil.CheckRange(month, 1, 12);
                NumberUtil.CheckRange(day, 1, maxMonthDay);

                TimeDMModel model = TimeUtil.minusDays(day, month, 1);
                Console.WriteLine("Предыдущая дата была: " + model.Day + " - " + model.Month);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (ArgumentOutOfRangeException ex) {
                Console.WriteLine("Ошибка: " + ex.ParamName);
            }
        }

        private static ushort GetUshort(string nameOfVar, int minValue, int maxValue)
        {
            Console.Write($"Введинте, пожалусто, {nameOfVar}, значение ожидается в формате ##0 и в границах от {minValue} и до {maxValue}: ");
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
