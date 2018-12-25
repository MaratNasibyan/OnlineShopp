using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Domain.Exceptions
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
//5656
    public class OrderingDomainException : Exception
    {
        public OrderingDomainException()
        { }

        public OrderingDomainException(string message)
            : base(message)
        { }

        public OrderingDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
