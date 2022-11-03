using SuperLogger;

namespace SuperApp;


internal class Program
{
    static void Main(string[] args)
    {
        var logger = new Logger() { EnabledLevel = LogLevel.Warning };

        var time = DateTime.UtcNow;

        logger.LogMessage(LogLevel.Error,$"Error: {time} Chyba");
        logger.LogMessage(LogLevel.Warning, $"Error: {time} Varovani");
        logger.LogMessage(LogLevel.Information, $"Error: {time} Info");
        logger.LogMessage(LogLevel.Warning, $"Cisty text");

    }
}
