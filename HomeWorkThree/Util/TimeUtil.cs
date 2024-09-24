using LaboratoryThree.TimeModel;

namespace LaboratoryThree.Util
{
    internal static class TimeUtil
    {
        public readonly static RangeOfTime DayRange = new RangeOfTime(1, 30);
        public readonly static RangeOfTime MonthRange = new RangeOfTime(1, 12);

        public static ushort GetDayBefore(ushort day, ushort month)
        {
            month = NumberUtil.CheckRange(month, 1, 12);
            day = NumberUtil.CheckRange(day, 1, 30);

            if (day <= 0) {
                return 30;
            }

            return (ushort)(day - 1);
        }
    }
}
