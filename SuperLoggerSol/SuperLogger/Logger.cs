using System.Runtime.CompilerServices;

namespace SuperLogger;

public class Logger
{
    public LogLevel EnabledLevel { get; init; } = LogLevel.Error;

    public void LogMessage(LogLevel level, string msg)
    {
        if (EnabledLevel < level) return;
        Console.WriteLine(msg);
    }

    public void LogMessage(LogLevel level, [InterpolatedStringHandlerArgument("", "level")] LogStringHandler handler)
    {
        if (EnabledLevel < level) return;
        Console.WriteLine(handler.GetFormattedText());
    }
}