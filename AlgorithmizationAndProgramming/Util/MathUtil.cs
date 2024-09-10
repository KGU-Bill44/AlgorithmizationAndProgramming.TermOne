using System;

namespace AlgorithmizationAndProgramming
{
    public static class MathUtil
    {

        public static double getLengthAreaFromRadius(int radius)
        {
            return radius * 2 * Math.PI;
        }

        public static double getAreaFromRadius(int radius)
        {
            return radius * Math.Pow(radius, 2) * Math.PI;
        }
    }
}
