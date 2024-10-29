using LaboratorySeven.MathExceptions;

namespace LaboratorySeven.MathSituation
{
    /// <summary>
    /// Класс проеднозначен для особых случает математических вычеслений.
    /// </summary>
    public static class MathNumber
    {
        /// <summary>
        /// Ппроверяет, является ли положительное, отличное от 0, число квадратом
        /// простого числа.
        /// </summary>
        /// <param name="anyNamber">Положительное число, отличное от нуля.</param>
        /// <returns>Возвращает true, если чило квадрат просто числа, иначе false</returns>
        /// <exception cref="NotSimpleNumberException">Если число меньше 0</exception>
        /// <exception cref="ZeroException">Если число 0</exception>
        public static bool IsNumberSquareOfPrimeNumber(long anyNamber)
        {
            if (anyNamber <= 0)
            {
                throw new NotSimpleNumberException($"Число {anyNamber} не натуральное");
            }

            double rootOfNumber = Math.Sqrt(anyNamber);
            return rootOfNumber % 1 == 0 
                   && IsPrimeNumber(Convert.ToInt64(rootOfNumber));
        }

        /// <summary>
        /// Проверяет, является ли модуль числа простым.
        /// </summary>
        /// <param name="anyNamber">Челое число отличное от нуля</param>
        /// <returns>Возвращает true, если модуль числа простое, иначе false</returns>
        /// <exception cref="ZeroException">Если передан 0</exception>
        private static bool IsPrimeNumber(long anyNamber)
        {
            if (anyNamber == 0)
            {
                throw new ZeroException("Число равно " + anyNamber);
            }

            anyNamber = Math.Abs(anyNamber);

            for (int i = 2; i < anyNamber; i++)
            {
                if (anyNamber % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}