using System;
using Enigma.Components;
using Microsoft.Extensions.Configuration;

namespace Enigma
{
    public class EnigmaMachine
    {
        // JSON configuration object
        internal static IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("config.json")
            .Build();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            IConfigurationSection section = config.GetSection("test");

            Console.WriteLine($"Test: {section["test1"]}");
            Keyboard keyboard = new Keyboard();
            while (true)
            {
                Keyboard.Input input = keyboard.GetSingleKeyInput();
                Console.Write(input.Key);
                if (input.Terminator) break;
            }
        }
    }
}
