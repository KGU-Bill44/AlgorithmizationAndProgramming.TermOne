namespace HomeWorkFive
{
    public static class MathUtil
    {
        public static uint SmallestNaturalDivisor(uint anyNumber)
        {
            if (anyNumber % 2 == 0)
            {
                return 2;
            }
            else if (anyNumber % 3 == 0)
            {
                return 3;
            } else if (anyNumber % 5 == 0)
            {
                return 5;
            }

            for (uint i = 7; i < anyNumber; i = GetNextSimplNumberAfter(i))
            {
                if (anyNumber % i == 0)
                {
                    return i;
                }
            }

            return anyNumber;
        }

        public static uint GetNextSimplNumberAfter(uint someNumber)
        {
            uint nextNumber = someNumber % 2 == 0 ? someNumber + 1 : someNumber + 2;
            for (int shift = 2; shift < nextNumber; shift++)
            {
                if (nextNumber % shift == 0)
                {
                    nextNumber = nextNumber + 2;
                }
            }

            return nextNumber;
        }
    }
}
