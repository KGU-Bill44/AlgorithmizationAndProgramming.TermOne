using HomeWorkSeven.EngineException;
using LaboratorySeven.MathExceptions;
using System.Text;

namespace HomeWorkSeven.Engine
{


    /// <summary>
    /// Математический интревал <see cref="MathInterval" />
    /// </summary>
    public static class MathInterval
    {
        /// <summary>
        /// Возвращает строку простых числе из интервала.
        /// </summary>
        /// <param name="firstEnd">Первый конец интервала</param>
        /// <param name="secondEnd">Второй конец интревала</param>
        /// <returns>Строка, стотоящая из простых чисел интервала</returns>
        /// <exception cref="NegativeNumberException">Возникает при указании одного конца меньше нуля</exception>
        /// <exception cref="InconsistencyIntervalEndException">Возникает при условии, что начсальный конец больше, чем конечный</exception>
        public static void Interval(int firstEnd, int secondEnd)
        {
            ValidateIntevalEnds(firstEnd, secondEnd);

            if (firstEnd > 1)
            {
                firstEnd = firstEnd - 1;
            }

            uint nextSimplNumber = GetNextSimpleNumberAfter(Convert.ToUInt32(firstEnd));

            while (nextSimplNumber <= secondEnd)
            {
                InfoOutputer.OutputConsoleWithWithSpase(nextSimplNumber);
                nextSimplNumber = GetNextSimpleNumberAfter(nextSimplNumber);
            }
        }

        /// <summary>
        /// Валидация интервала
        /// </summary>
        /// <param name="firstEnd">Первый конец интервала</param>
        /// <param name="secondEnd">Второй конец интревала</param>
        /// <exception cref="NegativeNumberException">Возникает при указании одного конца меньше нуля</exception>
        /// <exception cref="InconsistencyIntervalEndException">Возникает при условии, что начсальный конец больше, чем конечный</exception>
        private static void ValidateIntevalEnds(int firstEnd, int secondEnd)
        {
            if (firstEnd < 0 || secondEnd < 0)
            {
                throw new NegativeNumberException("Одни из концов интервыала является отрицательным числом");
            }

            if (firstEnd > secondEnd)
            {
                throw new InconsistencyIntervalEndException("Начало интервала не может быть больше, чем конечное");
            }
        }

        /// <summary>
        /// The GetNextSimpleNumberAfter
        /// </summary>
        /// <param name="someNumber">The someNumber<see cref="uint"/></param>
        /// <returns>The <see cref="uint"/></returns>
        private static uint GetNextSimpleNumberAfter(uint someNumber)
        {
            if (someNumber < 2)
            {
                return 2;
            }

            uint nextNumber = someNumber % 2 == 0 ? someNumber + 1 : someNumber + 2;
            int shift = 2;

            while (shift < nextNumber)
            {
                if (nextNumber % shift == 0)
                {
                    shift = 1;
                    nextNumber = nextNumber + 2;
                }

                shift = shift + 1;
            }

            return nextNumber;
        }
    }
}
