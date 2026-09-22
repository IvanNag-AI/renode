using System;
using System.Runtime.Serialization;

namespace Org.BouncyCastle.Crmf
{
    [Serializable]
    public class CrmfException
        : Exception
    {
        public CrmfException()
            : base()
        {
        }

        public CrmfException(string message)
            : base(message)
        {
        }

        public CrmfException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
