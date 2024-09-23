using HomeWorkTow.MathExtends.MathModel;
using HomeWorkTow.MathExtends.Service;
using HomeWorkTow.MathExtends.Util;

namespace HomeWorkTow.MathExtends.Situation
{
    internal class ESituation
    {
        public static readonly short RadiusFerstCircle = 15;
        public static readonly short RadiusSecondCircle = 25;

        public CircleResult CheckSituation(Point point)
        {
            if (CircleMathUtil.PointInCircle(point, RadiusFerstCircle)) {
                return CircleResult.IN_FIRST_RANGE;
            } else if (CircleMathUtil.PointOutOfCircle(point, RadiusSecondCircle)) {
                return CircleResult.OUT_SECODN_RANGE;
            } else if (CircleMathUtil.PointOnCircle(point, RadiusSecondCircle)
                || CircleMathUtil.PointOnCircle(point, RadiusFerstCircle)) {
                return CircleResult.ON_BOARD;
            } else {
                return CircleResult.IN_INVALID_ZONE;
            }
        }
    }
}
