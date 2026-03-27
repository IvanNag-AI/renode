//
// Copyright (c) 2012-2026 Antmicro
//
// This file is licensed under the MIT License.
// Full license text is available in the LICENSE file.

using System;

namespace Antmicro.Migrant.VersionTolerance
{
    /// <summary>
    /// Class representing exception thrown when version tolerance verification mechanism detects disallowed changes in type structures.
    /// </summary>
    [Serializable]
    public class VersionToleranceException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Antmicro.Migrant.VersionTolerance.VersionToleranceException"/> class.
        /// </summary>
        public VersionToleranceException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Antmicro.Migrant.VersionTolerance.VersionToleranceException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        public VersionToleranceException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Antmicro.Migrant.VersionTolerance.VersionToleranceException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">Inner exception.</param>
        public VersionToleranceException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

