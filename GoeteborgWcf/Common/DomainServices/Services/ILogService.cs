using DomainServices.enums;
using System;

namespace DomainServices.Services
{
    public interface ILogService : IDisposable
    {
        #region Public Methods and Operators

        /// <summary>
        /// The write log.
        /// </summary>
        /// <param name="level">
        /// The level.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="arguments">
        /// The arguments.
        /// </param>
        void WriteLog(EnumLogLevel level, string message, params object[] arguments);

        #endregion
    }
}
