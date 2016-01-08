using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib
{
    public class Logger
    {
        protected ILog log;


        public Logger(string loggerName)
        {
            log = LogManager.GetLogger(loggerName);
        }

        public Logger(Type loggerType)
        {
            log = LogManager.GetLogger(loggerType);
        }

        public void Debug(string message)
        {
            log.Debug(message);
        }

        public void Debug(string message, object arg0)
        {
            log.DebugFormat(message, arg0);
        }

        public void Debug(string message, params object[] args)
        {
            log.DebugFormat(message, args);
        }

        public void Info(string message)
        {
            log.Info(message);
        }

        public void Info(string message, object arg0)
        {
            log.InfoFormat(message, arg0);
        }

        public void Info(string message, params object[] args)
        {
            log.InfoFormat(message, args);
        }

        public void Warn(string message)
        {
            log.Warn(message);
        }

        public void Warn(string message, object arg0)
        {
            log.WarnFormat(message, arg0);
        }

        public void Warn(string message, params object[] args)
        {
            log.WarnFormat(message, args);
        }

        public void Error(Exception ex)
        {
            log.Error(ex);
        }

        public void Error(string message)
        {
            log.Error(message);
        }

        public void Error(string message, object arg0)
        {
            log.ErrorFormat(message, arg0);
        }

        public void Error(string message, params object[] args)
        {
            log.ErrorFormat(message, args);
        }
    }
}
