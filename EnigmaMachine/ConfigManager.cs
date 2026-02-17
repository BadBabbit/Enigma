using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Enigma;

internal static class ConfigManager
{
    // JSON configuration object
    private static string configFilePath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory, "config.json"
    );

    private static IConfiguration _config = new ConfigurationBuilder()
        .AddJsonFile(configFilePath, optional: false, reloadOnChange: false)
        .Build();

    /// <summary>
    /// interface to allow for config value injection in unit tests
    /// </summary>
    internal static IConfiguration Config
    {
        get => _config;
        set => _config = value ?? throw new ArgumentNullException(nameof(value));
    }

    internal static string GetConfigValue(string request)
    {

    }

}
