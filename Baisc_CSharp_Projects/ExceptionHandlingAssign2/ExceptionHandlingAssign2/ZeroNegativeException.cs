using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingAssign2
{
    class ZeroNegativeException : Exception
    {
        public ZeroNegativeException()
            : base() { }
        public ZeroNegativeException(string message)
            : base(message) { }
    }
}
