using LaboratoryThree.TimeModel;

namespace LaboratoryThree.Util
{
    internal static class NumberUtil
    {
        public static ushort CheckRange(ushort anyNumber, RangeOfTime range)
        {
            return CheckRange(anyNumber, range.MinValue, range.MaxValue);
        }

        public static ushort CheckRange(ushort anyNumber, double minBoard, double maxBoard)
        {
            if (minBoard <= anyNumber && maxBoard >= anyNumber)
            {
                return anyNumber;
            }
            else if (minBoard > anyNumber)
            {
                throw new ArgumentOutOfRangeException($"Число выходит за граници минимального порга: значение {anyNumber} не может быть ниже {maxBoard}");
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Число выходит за граници минимального порга: значение {anyNumber} не может привышать {maxBoard}");
            }
        }
    }
}
