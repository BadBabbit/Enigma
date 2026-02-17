using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Enigma;

internal class Logger
{
    private static object _lock = new object();
    private static ILogger instance;
    private static readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder =>
    {
        builder.SetMinimumLevel(LogLevel.Debug).AddConsole();
    });

    public static ILogger GetInstance()
    {
        if (instance == null)
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = _loggerFactory.CreateLogger("Enigma");
                }
            }
        }
        return instance;
    }
}
