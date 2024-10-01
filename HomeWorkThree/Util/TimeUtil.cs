using HomeWorkThree.Model;

namespace LaboratoryThree.Util
{
    internal static class TimeUtil
    {
        public static TimeDMModel minusDays(ushort day, ushort month, int minusedDays)
        {
            if (day - minusedDays <= 0)
            {
                if (month == 1)
                {
                    month = 13;
                }

                month = (ushort)(month - 1);
                minusedDays = Math.Abs(day - minusedDays);
                return minusDays(getMaxDayByMonth(month), month, minusedDays);
            }

            return new TimeDMModel((ushort)(day - minusedDays), month);
        }

        public static ushort getMaxDayByMonth(ushort month) {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    return 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    throw new ArgumentOutOfRangeException("Номер месяца вышла за пределы объявления месяцов (от 1 до 12)");
            }
        }
    }
}
