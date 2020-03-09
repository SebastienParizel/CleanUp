using System;

namespace CleanUp
{
    public class ConsoleWriter
    {
        private ConsoleLevel _logLevl = ConsoleLevel.Trace;

        public void SetLevel(ConsoleLevel level)
        {
            _logLevl = level;
        }

        public void Info(string message)
        {
            if (_logLevl <= ConsoleLevel.Info)
            {
                Console.ResetColor();
                Console.WriteLine(message);
            }
        }

        public void Trace(string message)
        {
            if (_logLevl <= ConsoleLevel.Trace)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(message);
            }
        }

        public void Warn(string message)
        {
            if (_logLevl <= ConsoleLevel.Warn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
            }
        }
    }

    public enum ConsoleLevel
    {
        Trace, Info, Warn
    }
}
