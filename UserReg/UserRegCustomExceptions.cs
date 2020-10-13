using System;
using System.Collections.Generic;
using System.Text;

namespace UserReg
{
    public class UserRegCustomExceptions : Exception
    {
        public enum ExceptionType
        {
            NULL_INPUT,
            EMPTY_INPUT
        }
        private readonly ExceptionType type;
        public UserRegCustomExceptions(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
