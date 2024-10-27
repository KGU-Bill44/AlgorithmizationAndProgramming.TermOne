using HomeWorkSeven.EngineException;

namespace LaboratorySeven.MathExceptions
{
    public class NegativeNumberException : MathException
    {
        public NegativeNumberException(string message) : base(message)
        {
        }
    }
}

