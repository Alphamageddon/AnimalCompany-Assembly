using System;

namespace AnimalCompany
{
    public class UnexpectedStateException : Exception
    {
        public UnexpectedStateException()
        {
        }

        public UnexpectedStateException(string message) : base(message)
        {
        }

        public UnexpectedStateException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}