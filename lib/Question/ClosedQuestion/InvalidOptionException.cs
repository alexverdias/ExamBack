using System;

namespace lib.Question.ClosedQuestion
{
    public class InvalidOptionException : Exception{
        public InvalidOptionException(string message) :base(message)
        {
            
        }
    }
}