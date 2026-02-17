using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Enigma;

internal class MachineConfig
{
    private static ILogger logger = Logger.GetInstance();
    public static MachineConfig Instance { get; private set; } = LoadConfig();

    public List<string> Plugboard { get; init; }
    public Rotors Rotors { get; init; }
    public Dictionary<char, char> Reflector { get; init;  }

    public static MachineConfig LoadConfig()
    {
        logger.LogDebug("Loading machine configuration from config.json");
        string json = File.ReadAllText("config.json");
        logger.LogDebug($"json string contents: {json}");
        if (json == null || json == "") {
            throw new JsonException("could not load json config string");
        }
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var config = JsonSerializer.Deserialize<MachineConfig>(json, options);
        if (config == null) {
            throw new JsonException("could not deserialise config file into machine config object");
        }
        return config;
    }
}

public class Rotors
{
    public Dictionary<string, Dictionary<char, char>> definitions { get; init; } = new();
    [JsonPropertyName("positions")]
    public List<RotorPosition> rotorPositions { get; init; } = new();
}

public class RotorPosition
{
    public string rotor { get; init; }
    public int position { get; init; }
}