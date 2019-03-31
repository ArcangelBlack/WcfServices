using DomainServices.enums;
using DomainServices.Services;
using log4net;

namespace DomainServices
{
    public sealed class Log4NetService : ILogService
    {
        #region Fields

        /// <summary>
        /// The logger.
        /// </summary>
        private readonly ILog logger;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Log4NetService"/> class.
        /// </summary>
        public Log4NetService()
        {
            log4net.Config.XmlConfigurator.Configure();
            this.logger = log4net.LogManager.GetLogger("Default");
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
        }

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
        public void WriteLog(EnumLogLevel level, string message, params object[] arguments)
        {
            switch (level)
            {
                case EnumLogLevel.Tracing:
                    this.logger.Debug(message);
                    break;
                case EnumLogLevel.Information:
                    this.logger.Info(message);
                    break;
                case EnumLogLevel.Error:
                    this.logger.Error(message);
                    break;
                case EnumLogLevel.Warning:
                    this.logger.Warn(message);
                    break;
            }
        }

        #endregion
    }
}
