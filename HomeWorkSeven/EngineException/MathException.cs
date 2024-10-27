using System;

namespace HomeWorkSeven.EngineException
{
    public class MathException : Exception
    {
        public MathException(string? message) : base(message)
        {
        }
    }
}