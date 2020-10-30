using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class CabInvoiceCustomException:Exception
    {
        public Exception exception;
        public enum Exception {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDES
            
        }
        public CabInvoiceCustomException(string message, Exception exception) : base(message)
        {
            this.exception = exception;
        }
    }
}
