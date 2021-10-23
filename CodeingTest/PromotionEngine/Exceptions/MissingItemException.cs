using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PromotionEngine.Exceptions
{
    public class MissingItemException : Exception
    {
        public MissingItemException()
        {
        }

        public MissingItemException(string message) : base(message)
        {
        }

        public MissingItemException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MissingItemException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
