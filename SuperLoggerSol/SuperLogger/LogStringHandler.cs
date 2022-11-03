using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SuperLogger
{
    [InterpolatedStringHandler]
    public ref struct LogStringHandler
    {
        private StringBuilder sb;
        private bool enabled;

        public LogStringHandler(int literalLength, int formatedCount, Logger logger, LogLevel level)
        {
            enabled = logger.EnabledLevel >= level;
            sb = new StringBuilder(literalLength);
            WriteLine($"Handler konstruktor, literalLength = {literalLength}, formatedCount = {formatedCount}");
        }

        public bool AppendLiteral(string s)
        {
            WriteLine($"Metoda AppendLiteral, s = {s}");
            if (!enabled) return enabled;
            sb.Append(s);
            WriteLine("Pridan text");
            return enabled;
        }

        public bool AppendFormatted<T>(T data)
        {
            WriteLine($"Metoda AppendFormatted, data = {data}");
            if (!enabled) return enabled;
            sb.Append(data?.ToString());
            WriteLine("Pridan formatovany text");
            return enabled;
        }

        internal string GetFormattedText() => sb.ToString();
    }
}
