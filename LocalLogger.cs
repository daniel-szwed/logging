using System.Collections.Generic;

namespace ArbreSoft.Logging
{
    public class LocalLogger : CompositeLogger
    {
        public LocalLogger(IList<Logger> loggers) : base(loggers) {}
    }
}