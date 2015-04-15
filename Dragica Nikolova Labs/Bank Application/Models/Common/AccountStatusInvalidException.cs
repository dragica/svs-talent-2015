using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
    public class AccountStatusInvalidException : Exception
    {
        public AccountStatusInvalidException() : base() { }
        public AccountStatusInvalidException(string message) : base(message) { }
        public AccountStatusInvalidException(string message, Exception innerException) :
            base(message, innerException) { }
        protected AccountStatusInvalidException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) :
            base(info, context) { }
        public override string ToString()
        {
            return Message;
        }
    }
}
