using HomeWorkOne.Clock.Util;

namespace HomeWorkOne.Clock.Service
{
    internal class GeometryClockService
    {

        public double getAngleByStartOfTime(ushort hour, ushort minutes, ushort second)
        {
            return (hour * ClockUtil.OneFractionOfHour) + (minutes * ClockUtil.OneFractionOfMinuts) + (second * ClockUtil.OneFractionOfSeconds);
        }
    }
}
