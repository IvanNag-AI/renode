using System;
using System.Runtime.Serialization;

namespace Org.BouncyCastle.Tls
{
    [Serializable]
    public class TlsFatalAlertReceived
        : TlsException
    {
        protected readonly byte m_alertDescription;

        public TlsFatalAlertReceived(short alertDescription)
            : base(Tls.AlertDescription.GetText(alertDescription))
        {
            if (!TlsUtilities.IsValidUint8(alertDescription))
                throw new ArgumentOutOfRangeException(nameof(alertDescription));

            m_alertDescription = (byte)alertDescription;
        }

        public virtual short AlertDescription
        {
            get { return m_alertDescription; }
        }
    }
}
