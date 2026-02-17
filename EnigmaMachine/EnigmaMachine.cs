using System;
using Microsoft.Extensions.Configuration;

using Enigma.Components;
using Enigma;


namespace Enigma
{
    public class EnigmaMachine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {

            List<string> plugboardConfig = ConfigManager.GetPlugboardConfig();
            Console.WriteLine($"Plugboard configuration:");
            foreach (string plugboardConnection in plugboardConfig)
            {
                Console.WriteLine($"\t{plugboardConnection}");
            }
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
