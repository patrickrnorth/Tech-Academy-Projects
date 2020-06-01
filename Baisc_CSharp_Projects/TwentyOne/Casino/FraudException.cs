using System;
using System.Collections.Generic;
using System.Text;

namespace Casino 
{
    class FraudException : Exception
    {
        public FraudException()
            : base() { }
        public FraudException(string message)
            :base(message) { }
    }
}
