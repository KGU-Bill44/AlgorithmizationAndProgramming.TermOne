namespace HomeWorkFive
{
    public static class MathUtil
    {
        public static uint SmallestNaturalDivisor(uint anyNumber)
        {
            uint i = 2;
            while (i < anyNumber)
            {
                if (anyNumber % i == 0)
                {
                    return i;
                }
                i = GetNextSimplNumberAfter(i);
            }

            return anyNumber;
        }

        public static uint GetNextSimplNumberAfter(uint someNumber)
        {
            uint nextNumber = someNumber % 2 == 0 ? someNumber + 1 : someNumber + 2;
            int shift = 2;

            while (shift < nextNumber) {
                if (nextNumber % shift == 0)
                {
                    nextNumber = nextNumber + 2;
                }
                shift = shift + 1;
            }

            return nextNumber;
        }
    }
}
