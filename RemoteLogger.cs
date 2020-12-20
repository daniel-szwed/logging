using System.Collections.Generic;

namespace ArbreSoft.Logging
{
    public class RemoteLogger : CompositeLogger
    {
        public RemoteLogger(IList<Logger> loggers) : base(loggers) { }
    }
}