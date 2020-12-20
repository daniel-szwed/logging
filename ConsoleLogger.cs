using System;

namespace ArbreSoft.Logging
{
    public class ConsoleLogger : Logger
    {
        public override void Log(string message)
        {
            Console.WriteLine(message);
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}