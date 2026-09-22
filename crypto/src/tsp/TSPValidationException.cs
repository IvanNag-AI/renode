using System;
using System.Runtime.Serialization;

namespace Org.BouncyCastle.Tsp
{
    /// <summary>
    /// Exception thrown if a TSP request or response fails to validate.
    /// </summary>
    /// <remarks>
    /// If a failure code is associated with the exception it can be retrieved using the <see cref="FailureCode"/>
    /// property.
    /// </remarks>
    [Serializable]
    public class TspValidationException
        : TspException
    {
        // TODO[api] Make private
        protected readonly int m_failureCode;

        public TspValidationException(string message)
            : this(message, -1)
        {
        }

        public TspValidationException(string message, int failureCode)
            : base(message)
        {
            m_failureCode = failureCode;
        }

        /// <returns>The failure code associated with this exception, if one is set.</returns>
        public int FailureCode => m_failureCode;
    }
}
