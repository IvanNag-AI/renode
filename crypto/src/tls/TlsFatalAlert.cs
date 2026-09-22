using System;
using System.Runtime.Serialization;

namespace Org.BouncyCastle.Tls
{
    [Serializable]
    public class TlsFatalAlert
        : TlsException
    {
        private static string GetMessage(short alertDescription, string detailMessage)
        {
            string msg = Tls.AlertDescription.GetText(alertDescription);
            if (null != detailMessage)
            {
                msg += "; " + detailMessage;
            }
            return msg;
        }

        protected readonly byte m_alertDescription;

        public TlsFatalAlert(short alertDescription)
            : this(alertDescription, null, null)
        {
        }

        public TlsFatalAlert(short alertDescription, string detailMessage)
            : this(alertDescription, detailMessage, null)
        {
        }

        public TlsFatalAlert(short alertDescription, Exception alertCause)
            : this(alertDescription, null, alertCause)
        {
        }

        public TlsFatalAlert(short alertDescription, string detailMessage, Exception alertCause)
            : base(GetMessage(alertDescription, detailMessage), alertCause)
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
