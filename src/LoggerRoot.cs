using System.Collections.Generic;

namespace ArbreSoft.Logging
{
    public class LoggerRoot : CompositeLogger
    {
        public LoggerRoot(IList<Logger> loggers) : base(loggers) { }
    }
}