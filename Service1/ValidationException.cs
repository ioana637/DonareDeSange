using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ValidationException : Exception
    {
        private String errorMessage;

        public ValidationException()
        {
        }

        public ValidationException(String message)
        {
            errorMessage = message;
        }

        public String GetMessage()
        {
            return errorMessage;
        }
    }
}
